using System;

namespace dwm_net_statusbar
{
    public static class Battery
    {
        private static string root = "/sys/class/power_supply/BAT0";
        public static string Status()
        {
            var capacityFile = System.IO.File.ReadAllText($"{root}/capacity").Trim();
            var statusFile = System.IO.File.ReadAllText($"{root}/status").Trim();
            return $"{capacityFile}%{FormatStatus(statusFile)}";
        }
        private static string FormatStatus(string status) {
            if (status.Trim() == "Discharging")
                return "-";
            return "+";
        }
    }
}
