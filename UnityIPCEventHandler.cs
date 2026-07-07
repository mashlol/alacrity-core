using Alacrity.Common;
using System;
using System.Runtime.InteropServices;
using System.Text;
using Xilium.CefGlue;

namespace Alacrity {
    public class UnityIPCEventHandler {

        private readonly OffscreenCEFClient cefClient;

        private CefEventFlags modifiers = CefEventFlags.None;
        private int mouseX = 0;
        private int mouseY = 0;

        private int lastClickButton = -1;
        private int lastClickMouseX;
        private int lastClickMouseY;
        private int lastClickTimeMs;
        private int lastClickCount;

        [DllImport("user32.dll")]
        private static extern uint GetDoubleClickTime();

        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(int nIndex);

        private const int SM_CXDOUBLECLK = 36;
        private const int SM_CYDOUBLECLK = 37;

        public UnityIPCEventHandler(OffscreenCEFClient cefClient) {
            this.cefClient = cefClient;
        }

        public void HandleEvent(byte[] buffer, int numBytes) {
            if (cefClient.GetHost() == null) {
                return;
            }

            EventType eventType = (EventType) buffer[0];

            switch (eventType) {
                case EventType.MousePosition:
                    HandleMousePositionEvent(buffer);
                    return;
                case EventType.MouseButton:
                    HandleMouseButtonEvent(buffer);
                    return;
                case EventType.Key:
                    HandleKeyEvent(buffer);
                    return;
                case EventType.MouseWheel:
                    HandleMouseWheelEvent(buffer);
                    return;
                case EventType.Resize:
                    HandleResizeEvent(buffer);
                    return;
                case EventType.LoadUrl:
                    HandleLoadUrlEvent(buffer, numBytes);
                    return;
                case EventType.SetFramerate:
                    HandleSetFramerateEvent(buffer);
                    return;
            }
        }

        private void HandleResizeEvent(byte[] buffer) {
            var width = ConvertInt(buffer, 1);
            var height = ConvertInt(buffer, 5);

            cefClient.GetOffscreenRenderHandler().SetDimensions(width, height);
        }

        private void HandleSetFramerateEvent(byte[] buffer) {
            var framerate = ConvertInt(buffer, 1);
            cefClient.GetHost().SetWindowlessFrameRate(framerate);
        }

        private void HandleLoadUrlEvent(byte[] buffer, int numBytes) {
            var url = Encoding.ASCII.GetString(buffer, 1, numBytes - 1);
            cefClient.GetHost().GetBrowser().GetMainFrame().LoadUrl(url);
        }

        private void HandleMousePositionEvent(byte[] buffer) {
            mouseX = ConvertInt(buffer, 1);
            mouseY = ConvertInt(buffer, 5);
            cefClient.GetHost().SendMouseMoveEvent(new CefMouseEvent {
                X = mouseX,
                Y = mouseY,
                Modifiers = modifiers,
            }, false);
        }

        private void HandleMouseButtonEvent(byte[] buffer) {
            mouseX = ConvertInt(buffer, 1);
            mouseY = ConvertInt(buffer, 5);
            byte button = buffer[9];
            bool isUp = buffer[10] == 1;

            CefMouseButtonType cefButton = CefMouseButtonType.Left;
            CefEventFlags flagToModify = CefEventFlags.LeftMouseButton;
            if (button == 1) {
                flagToModify = CefEventFlags.RightMouseButton;
                cefButton = CefMouseButtonType.Right;
            } else if (button == 2) {
                flagToModify = CefEventFlags.MiddleMouseButton;
                cefButton = CefMouseButtonType.Middle;
            }

            // Supposedly, we need to track "double" or "triple" clicks, the
            // browser doesn't handle this for us, nor does CEF, for some reason
            int clickCount = GetMouseClickCount(button, isUp, mouseX, mouseY);

            if (isUp) {
                modifiers &= ~flagToModify;
            } else {
                modifiers |= flagToModify;
            }

            cefClient.GetHost().SendMouseClickEvent(new CefMouseEvent {
                X = mouseX,
                Y = mouseY,
                Modifiers = modifiers,
            }, cefButton, isUp, clickCount);
        }

        private int GetMouseClickCount(byte button, bool isUp, int x, int y) {
            // Use the same click count for the matching mouse-up.
            if (isUp) {
                return Math.Max(lastClickCount, 1);
            }

            int nowMs = Environment.TickCount;

            int doubleClickTimeMs = (int) GetDoubleClickTime();
            int doubleClickWidth = GetSystemMetrics(SM_CXDOUBLECLK);
            int doubleClickHeight = GetSystemMetrics(SM_CYDOUBLECLK);

            bool sameButton = button == lastClickButton;

            bool closeEnough =
                Math.Abs(x - lastClickMouseX) <= doubleClickWidth / 2 &&
                Math.Abs(y - lastClickMouseY) <= doubleClickHeight / 2;

            bool soonEnough =
                unchecked(nowMs - lastClickTimeMs) <= doubleClickTimeMs;

            if (sameButton && closeEnough && soonEnough) {
                lastClickCount++;
            } else {
                lastClickCount = 1;
            }

            lastClickButton = button;
            lastClickMouseX = x;
            lastClickMouseY = y;
            lastClickTimeMs = nowMs;

            return lastClickCount;
        }

        private void HandleKeyEvent(byte[] buffer) {
            int unityKeyCodeInt = ConvertInt(buffer, 1);
            KeypressEventType eventType = (KeypressEventType) buffer[5];

            UnityKeyCode unityKeyCode = (UnityKeyCode) unityKeyCodeInt;

            int cefKeyCode = unityKeyCodeInt;

            if (eventType != KeypressEventType.Char) {
                cefKeyCode =
                    UnityKeyCodeMapping.GetWindowsVirtualKeyForUnityKeyCodeAsInt(unityKeyCode);

                var flagToModify = CefEventFlags.None;
                if (cefKeyCode == (int) WindowsVirtualKeyCode.Shift) {
                    flagToModify = CefEventFlags.ShiftDown;
                } else if (cefKeyCode == (int) WindowsVirtualKeyCode.Alt) {
                    flagToModify = CefEventFlags.AltDown;
                } else if (cefKeyCode == (int) WindowsVirtualKeyCode.Control) {
                    flagToModify = CefEventFlags.ControlDown;
                }

                if (eventType == KeypressEventType.Up) {
                    modifiers &= ~flagToModify;
                } else if (eventType == KeypressEventType.Down) {
                    modifiers |= flagToModify;
                }
            }

            cefClient.GetHost().SendKeyEvent(new CefKeyEvent {
                WindowsKeyCode = cefKeyCode,
                EventType = GetCefKeyEventType(eventType),
                Modifiers = eventType == KeypressEventType.Char ? 0 : modifiers,
            });
        }

        private CefKeyEventType GetCefKeyEventType(KeypressEventType ket) {
            switch (ket) {
                case KeypressEventType.Down:
                    return CefKeyEventType.RawKeyDown;
                case KeypressEventType.Up:
                    return CefKeyEventType.KeyUp;
                case KeypressEventType.Char:
                    return CefKeyEventType.Char;
            }

            throw new Exception($"Unknown event type: {ket}");
        }

        private void HandleMouseWheelEvent(byte[] buffer) {
            int deltaX = ConvertInt(buffer, 1);
            int deltaY = ConvertInt(buffer, 5);
            cefClient.GetHost().SendMouseWheelEvent(new CefMouseEvent {
                X = mouseX,
                Y = mouseY,
            }, deltaX, deltaY);
        }

        private int ConvertInt(byte[] buffer, int offset) {
            return (buffer[offset] << 0) +
                (buffer[offset + 1] << 8) +
                (buffer[offset + 2] << 16) +
                (buffer[offset + 3] << 24);
        }

    }
}