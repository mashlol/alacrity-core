using System.Text.RegularExpressions;

namespace Alacrity {
  public class Javascript {
      private static string INJECTED_JS =  @"
(function() {
  const ws = new WebSocket(""ws://127.0.0.1:{port}?s={securityKey}"");
  ws.binaryType = ""arraybuffer"";

  ws.onmessage = (e) => {
    window.dispatchEvent(new CustomEvent(""unitydata"", {detail: e.data}));
  };

  window.sendToUnity = (data) => {
    ws.send(data);
  };

  let latestActiveElement = document.activeElement;
  const handleFocusChange = () => {
    if (document.activeElement !== latestActiveElement) {
      const isFocused = document.activeElement !== document.body;
      window.sendToUnity(""_internal_focus:"" + isFocused);
    }

    latestActiveElement = document.activeElement;
  };
  window.addEventListener(""focus"", handleFocusChange, true);
  window.addEventListener(""blur"", handleFocusChange, true);

  let isElementHovered = false;
  window.addEventListener(""mousemove"", (e) => {
    const hoveredElement = document.elementFromPoint(e.clientX, e.clientY);

    const isElementCurrentlyHovered = hoveredElement !== document.documentElement;
    if (isElementHovered != isElementCurrentlyHovered) {
      window.sendToUnity(""_internal_hover:"" + isElementCurrentlyHovered);
    }
    isElementHovered = isElementCurrentlyHovered;
  });
})();

";

    public static string GetJSToInject(int wsPort, string wsSecurityKey) {
      var withPort = Regex.Replace(INJECTED_JS, "\\{port\\}", wsPort.ToString());
      return Regex.Replace(withPort, "\\{securityKey\\}", wsSecurityKey);
    }

  }
}