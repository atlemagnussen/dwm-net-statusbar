using System;

namespace dwm_net_statusbar {
    public static class Screen {
        public static string State() {
            var backlight = ShellHelper.Bash("xbacklight -get").Trim();
            double bl = 0;
            double.TryParse(backlight, out bl);
            bl = Math.Round(bl, 0);
            return bl.ToString();
        }
    }
}