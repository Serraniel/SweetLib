using System;
using System.IO;
using SweetLib.Classes.Storer;
using SweetLib.IO.Classes.Streaming;
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

            
            var f = Path.GetTempFileName();
            var ini = new IniFileStorer(f);
            System.Console.WriteLine(ini.ReadString("sec","key"));

            using (var stream = File.Create(@"S:\test.dat"))
            {
                StreamManager.SaveToStream(stream, 5);
                StreamManager.SaveToStream(stream, "Hallo Wellt eksde");
                StreamManager.SaveToStream(stream, 12d);
                StreamManager.SaveToStream(stream, DateTime.UtcNow);
            }

            using (var stream = File.OpenRead(@"S:\test.dat"))
            {
                StreamManager.LoadFromStream(stream, out int iValue);
                StreamManager.LoadFromStream(stream, out string sValue);
                StreamManager.LoadFromStream(stream, out double dValue);
                StreamManager.LoadFromStream(stream, out DateTime dtValue);

                System.Console.WriteLine(iValue);
                System.Console.WriteLine(sValue);
                System.Console.WriteLine(dValue);
                System.Console.WriteLine(dtValue);
            }

            System.Console.ReadLine();
        }
    }
}
