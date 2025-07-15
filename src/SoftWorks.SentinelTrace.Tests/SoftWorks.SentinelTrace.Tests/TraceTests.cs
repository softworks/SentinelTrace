using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftWorks.SentinelTrace;
using SoftWorks.SentinelTrace.Tests.Helpers;

namespace SoftWorks.SentinelTrace.Tests
{
    [TestClass]
    public class TraceTests : TraceTestBase
    {
        [TestInitialize]
        public void Init()
        {
            // 🔧 Set log path prefix for this test class
            log4net.GlobalContext.Properties["LogName"] = "SentinelTrace.TraceTests";
        }

        [TestMethod]
        public void CanEmitStartMarker()
        {
            using (var trace = GetTestLogger("ClockDirection"))
            { 
                trace.Debug("🟢 Begin test trace", LogGrade.Structured);

                Assert.IsTrue(trace.TraceId.Length == 8);
            }
        }
    }
}
