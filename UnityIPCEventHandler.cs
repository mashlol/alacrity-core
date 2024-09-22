using System;
using System.Text;
using Xilium.CefGlue;
using Alacrity.Common;

namespace Alacrity {
    public class UnityIPCEventHandler {

        private readonly OffscreenCEFClient cefClient;

        private static CefEventFlags modifiers = CefEventFlags.None;
        private static int mouseX = 0;
        private static int mouseY = 0;

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

            if (isUp) {
                modifiers &= ~flagToModify;
            } else {
                modifiers |= flagToModify;
            }
            cefClient.GetHost().SendMouseClickEvent(new CefMouseEvent {
                X = mouseX,
                Y = mouseY,
            }, cefButton, isUp, isUp ? 0 : 1);
        }

        private void HandleKeyEvent(byte[] buffer) {
            int unityKeyCodeInt = ConvertInt(buffer, 1);
            KeypressEventType eventType = (KeypressEventType) buffer[5];

            UnityKeyCode unityKeyCode = (UnityKeyCode)unityKeyCodeInt;

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
                Modifiers = modifiers,
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