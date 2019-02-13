using System;

namespace dwm_net_statusbar {
    public static class Temp {
        private static string root = "/sys/class/thermal/thermal_zone0";
        public static string State() {
            var tempFile = System.IO.File.ReadAllText($"{root}/temp").Trim();
            int tempInt;
            int.TryParse(tempFile, out tempInt);
            return $"{tempInt/1000}";
        }
    }
}