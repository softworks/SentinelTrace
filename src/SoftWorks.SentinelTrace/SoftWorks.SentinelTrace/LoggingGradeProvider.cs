namespace SoftWorks.SentinelTrace
{
    public static class LoggingGradeProvider
    {
        public static LogGrade GetGrade(string subsystem)
        {
            switch (subsystem)
            {
                case "ClockDirection":
                    return LogGrade.Diagnostic;
                default:
                    return LogGrade.Minimal;
            }
        }
    }

}
