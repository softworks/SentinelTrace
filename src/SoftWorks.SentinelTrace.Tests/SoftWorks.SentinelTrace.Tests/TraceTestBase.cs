using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftWorks.SentinelTrace;

namespace SoftWorks.SentinelTrace.Tests.Helpers
{
    public abstract class TraceTestBase
    {
        /// <summary>
        /// Creates a logical task logger for a given subsystem, setting up log4net pathing.
        /// </summary>
        protected LogicalTaskLogger GetTestLogger(string subsystem)
        {
            log4net.GlobalContext.Properties["LogName"] = $"SentinelTrace.{subsystem}";
            return new LogicalTaskLogger(subsystem, LogGrade.Diagnostic);
        }
    }
}
