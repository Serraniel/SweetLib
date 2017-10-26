using System.IO;
using SweetLib.Classes.Storer;
using SweetLib.Utils.Logger;

namespace SweetLib.Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger.GlobalLogLevel |= LogLevel.Debug | LogLevel.Trace;
            Logger.GlobalLogLevel=LogLevel.All;

            Logger.Trace("Trace!");
            Logger.Debug("Debug");
            Logger.Info("Hallo Welt");
            Logger.Warn("WARN!");
            Logger.Error("Error :(");

            System.Console.ReadLine();

            var f = Path.GetTempFileName();
            var ini = new IniFileStorer(f);
            System.Console.WriteLine(ini.ReadString("sec","key"));
        }
    }
}
