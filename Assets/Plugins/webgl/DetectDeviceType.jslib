// Credits:
// https://discussions.unity.com/t/how-can-i-determine-the-type-of-device-the-webgl-game-is-running-from/948792/3

mergeInto(LibraryManager.library, {
  IsMobileBrowser: function () {
    return (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent));
  },
  IsPreferredDesktopPlatform: function() {
    return (/Win64|Mac OS X|Linux x86_64/i.test(navigator.userAgent));
  }
  });