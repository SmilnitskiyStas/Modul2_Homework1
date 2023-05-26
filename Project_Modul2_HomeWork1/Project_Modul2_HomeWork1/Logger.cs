using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Modul2_HomeWork1
{
    internal class Logger
    {
        private static Logger _instance;

        public static string[] logString = new string [150];

        private static int countIteration = 0;

        private Logger() { }

        public static Logger Instance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }

        public void WriteLog(string typeLog, string message)
        {
            logString[countIteration] = $"{DateTime.Now} | {typeLog}: {message}";

            Console.WriteLine(logString[countIteration]);

            countIteration++;


            File.WriteAllLines("LogFile.txt", logString);
        }
    }
}
