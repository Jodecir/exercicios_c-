namespace Construtores.Models
{
    public sealed class Log
    {
        private static Log _log;
        public string PropriedadeLog {get; set;}

        private Log()
        {
        }

        public static Log GetInstance()
        {
            return _log ??= new Log();
        }
    }
}