using System;
using System.Net;
using System.Threading;

namespace dwm_net_statusbar
{
    class Program
    {
        public static void Main(string[] args)
        {
            var run = true;
            while(run) {
                try {
                    var battery = Battery.Status();
                    var temp = Temp.State();
                    var celsius = '\u2103';
                    var time = DateTime.Now;
                    var ipLan = Network.InterfaceStatus();
                    Console.WriteLine(ipLan);
                    var icon = "\ud83d\udd0b";
                    var status = $"{ipLan} {icon}{battery} {temp}{celsius} {time}";
                    Console.WriteLine(status);
                    ShellHelper.Bash($"xsetroot -name \"{status}\"");
                }
                catch(Exception e) {
                    Console.WriteLine(e.Message);
                    ShellHelper.Bash($"xsetroot -name \"error\"");
                }
                Thread.Sleep(10000);
            }
        }
    }
}
