namespace Project_Modul2_HomeWork1
{
    internal class Actions
    {
        public static Result FirstMethod()
        {
            Result result = new Result(LogStatus.Info);

            Logger.WriteLog(Logger.GetTypeLog(LogStatus.Info), result.Message);

            return result;
        }

        public static Result SecondMethod()
        {
            Result result = new Result(LogStatus.Warning);

            Logger.WriteLog(Logger.GetTypeLog(LogStatus.Warning), result.Message);

            return result;
        }

        public static Result ThirdMethod()
        {
            Result result = new Result(LogStatus.Error);

            Logger.WriteLog(Logger.GetTypeLog(LogStatus.Error), result.Message);

            return result;
        }
    }
}
