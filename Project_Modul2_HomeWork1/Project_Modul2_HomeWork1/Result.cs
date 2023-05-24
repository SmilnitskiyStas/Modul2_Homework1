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

        public Result(WorkStatus logName) 
        {
            if (logName.ToString().ToLower() == "info")
            {
                Status = true;

                Message = "Start method:";
            }
            else if (logName.ToString().ToLower() == "warning")
            {
                Status = true;

                Message = "Skipped logic in method:";
            }
            else 
            { 
                Status = false;

                Message = "I broke a logic";
            }
        }
    }
}
