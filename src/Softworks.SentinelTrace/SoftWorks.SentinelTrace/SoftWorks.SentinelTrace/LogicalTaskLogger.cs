using log4net;
using System;
using System.Text;

namespace SoftWorks.SentinelTrace
{
    public class LogicalTaskLogger : IDisposable
    {
        private readonly StringBuilder _syndrome = new StringBuilder();
        private readonly ILog _log;
        private readonly string _subsystem;
        private readonly LogGrade _grade;
        private readonly string _id;

        public LogicalTaskLogger(string subsystem, LogGrade? overrideGrade = null)
        {
            _subsystem = subsystem;
            _grade = overrideGrade ?? LoggingGradeProvider.GetGrade(subsystem);
            _log = LogManager.GetLogger(subsystem);
            _id = Guid.NewGuid().ToString("N").Substring(0, 8);

            Info($"🟢 Start trace [{_id}]", LogGrade.Structured);
        }

        public void Debug(string message, LogGrade requiredGrade = LogGrade.Structured)
        {
            if (_grade >= requiredGrade)
            {
                _log.Debug($"[{_id}] {message}");
                if (_grade >= LogGrade.Verbose) _syndrome.AppendLine(message);
            }
        }

        public void Info(string message, LogGrade requiredGrade = LogGrade.Minimal)
        {
            if (_grade >= requiredGrade)
                _log.Info($"[{_id}] {message}");
        }

        public void Error(string message)
        {
            _log.Error($"[{_id}] ❌ {message}");
        }

        public string Syndrome => _syndrome.ToString();

        public void Dispose()
        {
            if (_grade >= LogGrade.Structured)
                _log.Info($"🛑 End trace [{_id}]");
        }
    }

}
