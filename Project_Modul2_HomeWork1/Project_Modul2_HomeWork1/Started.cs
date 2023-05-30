using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Modul2_HomeWork1
{
    internal class Started
    {
        public Started() { }

        public void Run()
        {
            Random random = new Random();

            Result result = null;

            for (int i = 0; i < 100; i++)
            {
                int choice = random.Next(0, 3);

                switch (choice)
                {
                    case 0:
                        result = Actions.FirstMethod();
                        break;
                    case 1:
                        result = Actions.SecondMethod();
                        break;
                    case 2:
                        result = Actions.ThirdMethod();
                        break;
                }

                if (result.Status == false)
                {
                    Logger.Instance().WriteLog(((EnumLogStatus)choice).ToString(), "Action failed by а reason: " + result.Message);
                }
            }

            string[] logData = Logger.Instance().GetLogData();

            WriteLogFile(logData);
        }

        private void WriteLogFile(string[] logData)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < logData.Length; i++)
            {
                if (logData[i] != null)
                {
                    stringBuilder.AppendLine(logData[i]);
                }
            }

            File.WriteAllText("LogFile.txt", stringBuilder.ToString());
        }
    }
}
