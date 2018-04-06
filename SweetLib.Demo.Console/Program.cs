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
            }

            using (var stream = File.OpenRead(@"S:\test.dat"))
            {
                int value;
                StreamManager.LoadFromStream(stream, out value);
                System.Console.WriteLine(value);
            }

            System.Console.ReadLine();
        }
    }
}
