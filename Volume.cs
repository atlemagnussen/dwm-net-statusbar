using System;

namespace dwm_net_statusbar {
    public static class Volume {
        public static string State() {
            var sinks = ShellHelper.Bash("pactl list sinks");
            var lines = sinks.Split("\n\t");
            var ret = string.Empty;
            foreach(var line in lines) {
                if (line.StartsWith("Mute")) {
                    var muted = line.Replace("Mute: ", "");
                    if (muted == "yes") {
                        ret += "Mute";
                    }
                }
                if (line.StartsWith("Volume")) {
                    var words = line.Split(" ");
                    foreach(var w in words) {
                        if (w.Contains("%")) {
                            ret += $"{w}";
                            return ret;
                        }
                    }
                }
            }
            return ret;
        }
    }
}