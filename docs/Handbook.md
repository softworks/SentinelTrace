## 📚 SentinelTrace Handbook  
*A symbolic diagnostic framework for software that works.*

---

## 🧭 Philosophy

SentinelTrace isn’t just about logging—it’s about **traceability**, **clarity**, and **semantic commentary** embedded directly in the code path. It transforms runtime behavior into structured meaning, combining minimalism with diagnostic expressiveness.

> 🧠 Built around symbolic markers, subsystem awareness, and ergonomic verbosity through graded logging.

---

## 🔹 Core Concepts

### ✅ LogGrade

Verbosity levels that guide what gets emitted, and when.

| Grade        | Purpose                          | Emitted When                           |
|--------------|----------------------------------|----------------------------------------|
| `Minimal`    | Always emitted                   | Core activity                          |
| `Structured` | Lifecycle events & commentary    | Start/End markers, contextual trails   |
| `Diagnostic` | Deep trace for analysis/testing  | Verbose subsystems, test harness       |

Grades are selected via `LoggingGradeProvider`, or manually overridden during logger instantiation.

---

### 🧠 LogicalTaskLogger

Scoped diagnostic companion with symbolic trace output.

```csharp
using (var trace = new LogicalTaskLogger("ClockDirection"))
{
    trace.Debug("🟢 Start task trace", LogGrade.Structured);
}
```

Creates:

- A unique 8-digit trace ID  
- Timestamped entries with graded verbosity  
- Optional `Syndrome` trail via internal commentary

---

## 🧪 Test Harness Strategy

MSTest-based harness that integrates subsystem-aware trace sessions, symbolic output, and verbose mode when needed.

```csharp
[TestMethod]
public void CanInitializeTaskLogger()
{
    log4net.GlobalContext.Properties["LogName"] = "SentinelTrace.Tests";

    using (var trace = new LogicalTaskLogger("TSR.TestRunner"))
    {
        trace.Info("🧪 Validating instantiation", LogGrade.Structured);
        Assert.IsNotNull(trace);
    }
}
```

### 🧬 Enhancements (Optional)

- `SyndromeTestHelper`: Validates commentary trails  
- `SymbolicAssert`: Wraps assertions with visual trace  
- `TraceTestBase`: Consistent logger patterns for subsystem tests

---

## 🧠 Symbolic Conventions

| Symbol     | Meaning                          |
|------------|----------------------------------|
| 🟢          | Start of lifecycle               |
| 🔴         | Cancellation or failure trigger  |
| 🔍         | Inspection or review             |
| ✅ / ❌    | Test assertion result            |
| 🧪         | Testing activity or trace        |
| 🔒         | Identity or security tag         |

Used freely throughout trace messages and syndrome commentary to aid visual clarity and semantic scanning.

---

## ⚙️ Configuration Layers

SentinelTrace uses `log4net` with structured output targeting console, file, and trace channels.

### 🔧 App.config

```xml
<configuration>
  <configSections>
    <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
  </configSections>

  <log4net configSource="log4net.config" />

  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8" />
  </startup>

  <appSettings>
    <add key="EnvironmentName" value="DiagnosticTest" />
    <add key="LogSubsystem" value="SentinelTrace.Tests" />
  </appSettings>
</configuration>
```

### 🔧 log4net.config Highlights

- `TraceAppender`: For debugger visibility  
- `ConsoleAppender` and `ColorConsoleAppender`: Emoji-enhanced live feedback  
- `RollingFileAppender`: Structured file logs, per-subsystem pathing via `%property{LogName}`  
- `FileAppender`: NHibernate trace isolation (`nhibernate.log`)  

To ensure symbolic output is preserved, UTF-8 encoding and `%m%n` patterns are used.

---

### 📁 Output Path Mapping

```csharp
log4net.GlobalContext.Properties["LogName"] = "SentinelTrace.ClockDirection";
```

This ensures each subsystem's log is routed cleanly, with rolling structure and timestamp precision.

---

## 🧭 Navigation Forward

- Next Section: Subsystem Patterns (`ClockDirection`, `ValidationEngine`, `SyncOps`)  
- Future Section: Syndrome Interpretation and Commentary Trail Techniques  
- Trace Styling: LogSymbols registry, emoji selectors, and semantic formatting
