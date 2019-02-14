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
                    var time = DateTime.Now.ToString("yyyy-MM-dd") + " \x231A" + DateTime.Now.ToString("HH:mm");
                    var ipLan = Network.InterfaceStatus();
                    var vol = Volume.State();
                    var scr = Screen.State();
                    Console.WriteLine(ipLan);
                    var status = $"\x25BD{ipLan} \x26A1{battery} {temp}{celsius} \x25C0{vol} \x239A{scr}% {time}";
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
