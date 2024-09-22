using System;
using System.IO;
using System.Security;
using Xilium.CefGlue;
using Alacrity.Common;

namespace Alacrity {

    public class OffscreenCEFClient : CefClient {

        private readonly OffscreenLoadHandler _loadHandler;
        private readonly OffscreenRenderHandler _renderHandler;
        private readonly CefLifeSpanHandler _lifeSpanHandler;

        private CefBrowserHost sHost;
        private Action<string, CefPaintElementType> onAcceleratedPaintAction;
        private Action<bool> onPopupShow;
        private Action<int, int, int, int> onPopupSize;

        public OffscreenCEFClient(int width, int height) {
            _loadHandler = new OffscreenLoadHandler(this);
            _renderHandler = new OffscreenRenderHandler(width, height, this);
            _lifeSpanHandler = new LifeSpanHandler();
        }

        public void OnAcceleratedPaint(Action<string, CefPaintElementType> action) {
            onAcceleratedPaintAction = action;
        }

        public void OnPopupShow(Action<bool> action) {
            onPopupShow = action;
        }

        public void OnPopupSize(Action<int, int, int, int> action) {
            onPopupSize = action;
        }

        public void Shutdown() {
            if (sHost != null) {
                sHost.CloseBrowser(true);
                sHost.Dispose();
                sHost = null;
            }
        }

        public CefBrowserHost GetHost() {
            return sHost;
        }

        protected override CefRenderHandler GetRenderHandler() {
            return _renderHandler;
        }

        public OffscreenRenderHandler GetOffscreenRenderHandler() {
            return _renderHandler;
        }

        protected override CefLoadHandler GetLoadHandler() {
            return _loadHandler;
        }

        protected override CefLifeSpanHandler GetLifeSpanHandler() {
            return _lifeSpanHandler;
        }

        internal class OffscreenLoadHandler : CefLoadHandler {
            private readonly OffscreenCEFClient client;

            public OffscreenLoadHandler(OffscreenCEFClient client) {
                this.client = client;
            }

            protected override void OnLoadStart(CefBrowser browser, CefFrame frame, CefTransitionType transitionType) {
                if (browser != null) {
                    client.sHost = browser.GetHost();
                    browser.GetHost().SetFocus(true);
                }
            }
        }

        public class OffscreenRenderHandler : CefRenderHandler {

            private int _windowWidth;
            private int _windowHeight;
            private readonly OffscreenCEFClient cefClient;

            public OffscreenRenderHandler(int windowWidth, int windowHeight, OffscreenCEFClient client) {
                _windowWidth = windowWidth;
                _windowHeight = windowHeight;
                cefClient = client;
            }

            public void SetDimensions(int newWidth, int newHeight) {
                _windowWidth = newWidth;
                _windowHeight = newHeight;
                cefClient.GetHost().WasResized();
            }

            protected override CefAccessibilityHandler GetAccessibilityHandler() {
                return null;
            }

            protected override bool GetRootScreenRect(CefBrowser browser, ref CefRectangle rect) {
                GetViewRect(browser, out rect);
                return true;
            }

            protected override bool GetScreenPoint(CefBrowser browser, int viewX, int viewY, ref int screenX, ref int screenY) {
                screenX = viewX;
                screenY = viewY;
                return true;
            }

            protected override void GetViewRect(CefBrowser browser, out CefRectangle rect) {
                rect = new CefRectangle {
                    X = 0,
                    Y = 0,
                    Width = _windowWidth,
                    Height = _windowHeight
                };
            }

            protected override void OnAcceleratedPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr sharedHandle) {}

            protected override void OnAcceleratedPaint2(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, string sharedHandle, bool newTexture) {
                if (newTexture) {
                    cefClient.onAcceleratedPaintAction?.Invoke(sharedHandle, type);
                }
            }

            [SecurityCritical]
            protected override void OnPaint(CefBrowser browser, CefPaintElementType type, CefRectangle[] dirtyRects, IntPtr buffer, int width, int height) {}

            protected override bool GetScreenInfo(CefBrowser browser, CefScreenInfo screenInfo) {
                return false;
            }

            protected override void OnPopupShow(CefBrowser browser, bool show) {
                cefClient.onPopupShow?.Invoke(show);
            }

            protected override void OnPopupSize(CefBrowser browser, CefRectangle rect) {
                cefClient.onPopupSize?.Invoke(rect.X, rect.Y, rect.Width, rect.Height);
            }

            protected override void OnScrollOffsetChanged(CefBrowser browser, double x, double y) {}

            protected override void OnImeCompositionRangeChanged(CefBrowser browser, CefRange selectedRange, CefRectangle[] characterBounds) {}
        }

        internal class LifeSpanHandler : CefLifeSpanHandler {

            protected override void OnAfterCreated(CefBrowser browser) {}

        }

        public class RenderProcessHandler : CefRenderProcessHandler {

            protected override void OnContextCreated(CefBrowser browser, CefFrame frame, CefV8Context context) {
                context.TryEval(
                    Javascript.GetJSToInject(FileIPC.GetWSPort(), FileIPC.GetWSSecurityKey()),
                    null,
                    0,
                    out CefV8Value ret,
                    out CefV8Exception exception);
            }
        }

        public class OffscreenCEFApp : CefApp {

            private readonly RenderProcessHandler _renderProcessHandler;

            public OffscreenCEFApp() {
                _renderProcessHandler = new RenderProcessHandler();
            }

            protected override CefRenderProcessHandler GetRenderProcessHandler() {
                return _renderProcessHandler;
            }



            protected override void OnBeforeCommandLineProcessing(string processType, CefCommandLine commandLine) {
                var chromeArgs = CommandLineSwitches.Deserialize(File.ReadAllText("cargs"));
                var rawArgs = chromeArgs.GetRawSwitches();
                foreach (var arg in rawArgs) {
                    if (string.IsNullOrEmpty(arg.value)) {
                        commandLine.AppendSwitch(arg.name);
                    } else {
                        commandLine.AppendSwitch(arg.name, arg.value);
                    }
                }
            }
        }
    }
}