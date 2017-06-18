using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmanMehara.Windows.Services
{
    static class Logger
    {

        public enum LogLevel
        {
            DEBUG,
            INFO,
            WARNING,
            ERROR
        }

        public static void Log(String line, LogLevel logLevel)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\logfile", true);
                streamWriter.Write(String.Format("[{0}] {1} # {2}. \n", DateTime.Now.ToString(), logLevel.ToString(), line));
                streamWriter.Flush();
                streamWriter.Close();
            }
            catch
            {
                //Write to Event Log
            }
            
        }
    }
}
