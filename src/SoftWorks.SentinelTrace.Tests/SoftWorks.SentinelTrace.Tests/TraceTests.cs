using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftWorks.SentinelTrace.Tests
{
    [TestClass]
    public class TraceTests
    {
        [TestMethod]
        public void CanInitializeTaskLogger()
        {
            using (var trace = new LogicalTaskLogger("TestSubsystem"))
            {
                trace.Debug("🔍 Test trace active", LogGrade.Minimal);
                Assert.IsNotNull(trace);
            }
        }
    }
}
