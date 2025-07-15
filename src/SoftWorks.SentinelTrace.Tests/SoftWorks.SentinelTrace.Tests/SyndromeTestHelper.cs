namespace SoftWorks.SentinelTrace.Tests.Helpers
{
    public static class SyndromeTestHelper
    {
        /// <summary>
        /// Verifies if the syndrome trail includes a given symbolic marker.
        /// </summary>
        public static bool ContainsMarker(string syndromeTrail, string marker)
        {
            return !string.IsNullOrWhiteSpace(syndromeTrail) && syndromeTrail.Contains(marker);
        }

        /// <summary>
        /// Strips symbols and returns readable trail (optional for console output).
        /// </summary>
        public static string NormalizeSyndrome(string syndromeTrail)
        {
            if (string.IsNullOrWhiteSpace(syndromeTrail)) return string.Empty;
            return syndromeTrail.Replace("🧪", "").Replace("✅", "").Replace("❌", "").Trim();
        }
    }
}
