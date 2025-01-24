using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Logger
    {
        private static Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        private static readonly object _lock = new object();
        private Logger() { }
        public static Logger Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public void LogMessage(DateTime date, string message)
        {
            String inputText = $"Log create on date : {date} with message : {message} : {Environment.NewLine}";

            lock (_lock)
            {
                File.AppendAllText("log.txt", inputText);
            }
        }
    }
}
