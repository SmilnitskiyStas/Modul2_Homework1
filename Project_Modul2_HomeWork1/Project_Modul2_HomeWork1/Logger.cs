using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Modul2_HomeWork1
{
    enum LogStatus
    {
        Info,
        Warning,
        Error
    }

    internal class Logger
    {
        public static string[] logString = new string [150];

        private static int countIteration = 0;

        private Logger() { }

        public static string WriteLog(string TypeLog, string message)
        {
            //Console.WriteLine($"{DateTime.Now} | {TypeLog}: {message}");

            logString[countIteration] = $"{DateTime.Now} | {TypeLog}: {message}";

            countIteration++;

            File.WriteAllLines("LogFile.txt", logString);

            return $"{DateTime.Now} | {TypeLog}: {message}";
        }

        public static string GetTypeLog(LogStatus workStatus)
        {
            return workStatus.ToString();
        }
    }
}
