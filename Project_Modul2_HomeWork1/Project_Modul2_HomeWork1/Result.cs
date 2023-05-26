using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Modul2_HomeWork1
{
    internal class Result
    {
        public bool Status { get; set; }

        public string Message { get; set; }

        public Result(EnumLogStatus logName) 
        {
            if (logName.ToString().ToLower() == "info")
            {
                InfoStatus();
            }
            else if (logName.ToString().ToLower() == "warning")
            {
                WarningStatus();
            }
            else 
            { 
                ErrorStatus();
            }
        }

        private void InfoStatus()
        {
            Status = true;

            Message = "Start method:";
        }

        private void WarningStatus()
        {
            Status = true;

            Message = "Skipped logic in method:";
        }

        private void ErrorStatus()
        {
            Status = false;

            Message = "I broke a logic";
        }
    }
}
