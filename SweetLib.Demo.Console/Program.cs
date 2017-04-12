using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
