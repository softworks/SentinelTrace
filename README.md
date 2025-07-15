# SentinelTrace

*A lightweight, semantic logging framework for .NET Framework 4.8 built on log4net.*

---

## 🎯 Purpose

SentinelTrace provides parallel-safe diagnostics with graded verbosity, symbolic trace markers, and contextual commentary to enhance real-time traceability across enterprise subsystems.

It’s built for structured insight—not just output.

---

## 🚀 Features

- 🛡 **LogGrade** system for subsystem-specific verbosity
- 🔄 Scoped `LogicalTaskLogger` for structured lifecycle logging
- 💬 `Syndrome` commentary trails for post-analysis
- 🧠 Symbolic markers via `LogSymbols` for intuitive readability
- 🔌 Built on `log4net` (no runtime lock-in; config-flexible)

---

## 🛠 Quick Start

```csharp
using SoftWorks.SentinelTrace;

using var trace = new LogicalTaskLogger("ClockDirection");
trace.Debug($"{LogSymbols.Start} Resolving auto clock", LogGrade.Minimal);
// ...
trace.Error($"{LogSymbols.Error} Missing rule margins.");
