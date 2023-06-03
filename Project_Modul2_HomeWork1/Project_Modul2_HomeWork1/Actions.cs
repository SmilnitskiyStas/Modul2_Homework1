namespace Project_Modul2_HomeWork1
{
    internal class Actions
    {
        public static Result FirstMethod()
        {
            Result result = new Result(EnumLogStatus.Info);

            Logger log = Logger.Instance();

            log.WriteLog(EnumLogStatus.Info.ToString(), result.Message);

            return result;
        }

        public static Result SecondMethod()
        {
            Result result = new Result(EnumLogStatus.Warning);

            Logger log = Logger.Instance();

            log.WriteLog(EnumLogStatus.Warning.ToString(), result.Message);

            return result;
        }

        public static Result ThirdMethod()
        {
            Result result = new Result(EnumLogStatus.Error);

            Logger log = Logger.Instance();

            log.WriteLog(EnumLogStatus.Error.ToString(), result.Message);

            return result;
        }
    }
}
