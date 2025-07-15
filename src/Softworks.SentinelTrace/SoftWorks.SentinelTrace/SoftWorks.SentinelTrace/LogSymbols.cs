namespace SoftWorks.SentinelTrace
{
    public static class LogSymbols
    {
        public static LogSymbolStyle Style = LogSymbolStyle.Emoji;

        public static string Abort
        {
            get { return GetSymbol("🧨", "[ABORT]"); }
        }

        public static string Adjust
        {
            get { return GetSymbol("🧮", "[ADJUST]"); }
        }

        public static string Attach
        {
            get { return GetSymbol("📎", "[ATTACH]"); }
        }

        public static string Audit
        {
            get { return GetSymbol("🧾", "[AUDIT]"); }
        }
        public static string Build
        {
            get { return GetSymbol("🛠", "[BUILD]"); }
        }

        public static string Commit
        {
            get { return GetSymbol("✅", "[COMMIT]"); }
        }

        public static string Create
        {
            get { return GetSymbol("🔧", "[CREATE]"); }
        }

        public static string Error
        {
            get { return GetSymbol("⛔", "[FAIL]"); }
        }

        public static string Fudge
        {
            get { return GetSymbol("🩹", "[FUDGE]"); }
        }

        public static string Info
        {
            get { return GetSymbol("ℹ", "[INFO]"); }
        }

        public static string Link
        {
            get { return GetSymbol("🔗", "[LINK]"); }
        }

        public static string Missing
        {
            get { return GetSymbol("❓", "[MISSING]"); }
        }

        public static string OK
        {
            get { return GetSymbol("✓", "[OK]"); }
        }

        public static string Parse
        {
            get { return GetSymbol("📋", "[PARSE]"); }
        }

        public static string Perf
        {
            get { return GetSymbol("⏱", "[PERF]"); }
        }

        public static string Policy
        {
            get { return GetSymbol("📜", "[POLICY]"); }
        }

        public static string Retry
        {
            get { return GetSymbol("🔁", "[RETRY]"); }
        }

        public static string Save
        {
            get { return GetSymbol("💾", "[SAVE]"); }
        }

        public static string Skip
        {
            get { return GetSymbol("↩", "[SKIP]"); }
        }

        public static string Start
        {
            get { return GetSymbol("▶", "[START]"); }
        }
        public static string Test
        {
            get { return GetSymbol("🧪", "[TEST]"); }
        }

        public static string Trace
        {
            get { return GetSymbol("🔍", "[TRACE]"); }
        }

        public static string Warn
        {
            get { return GetSymbol("⚠", "[WARN]"); }
        }
        private static string GetSymbol(string emoji, string ascii)
        {
            switch (Style)
            {
                case LogSymbolStyle.Emoji: return emoji;
                case LogSymbolStyle.Ascii: return ascii;
                case LogSymbolStyle.None: return string.Empty;
                default: return ascii;
            }
        }
    }

}
