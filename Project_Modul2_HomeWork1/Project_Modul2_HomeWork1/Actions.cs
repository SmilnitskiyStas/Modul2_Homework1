using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Modul2_HomeWork1
{
    enum WorkStatus
    {
        Error,
        Info,
        Warning
    }
    internal class Actions
    {
        public static Result FirstMethod()
        {
            Logger log = Logger.GetInstance();
            log.WriteLog(log.GetTypeLog(WorkStatus.Info), new Result(WorkStatus.Info).Message);

            return new Result(WorkStatus.Info);
        }
    }
}
