using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Modul2_HomeWork1
{
    internal class Logger
    {
        private static Logger instance;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void WriteLog(string TypeLog, string message)
        {
            Console.WriteLine($"{DateTime.Now}| {TypeLog}: {message}");
        }

        public string GetTypeLog(WorkStatus workStatus)
        {
            return workStatus.ToString();
        }
    }
}
