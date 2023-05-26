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
            Result[] results = new Result[3] { Actions.FirstMethod(), Actions.SecondMethod(), Actions.ThirdMethod() };

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int randomInt = random.Next(1, 4);

                Result result = results[randomInt - 1];

                if (result.Status == false)
                {
                    string logger = Logger.WriteLog(Logger.GetTypeLog((LogStatus)randomInt - 1), $"Action failed by а reason: {result.Message}");

                    Console.WriteLine(logger);
                }
                else if (result.Status == true && randomInt == 1)
                {
                    Actions.FirstMethod();
                }
                else
                {
                    Actions.SecondMethod();
                }
            }

            string[] strings = Logger.logString;
        }
    }
}
