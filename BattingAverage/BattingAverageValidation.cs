using System;

namespace BattingAverage
{
    public class BattingAverageValidation
    {
        public double Hits { get; set; }
        public double AtBats { get; set; }
        private const int MinimumAtBats = 300;


        public BattingAverageValidation(string hits, string atbats)
        {
            double safeHits;
            double safeAtbats;

            safeHits = double.TryParse(hits, out safeHits) ? safeHits : 0;
            safeAtbats = double.TryParse(atbats, out safeAtbats) ? safeAtbats : MinimumAtBats;

            safeHits = safeHits > safeAtbats || safeHits < 1 ? 0 : safeHits;
            safeAtbats = Math.Abs(safeAtbats) < 1 ? MinimumAtBats : safeAtbats;

            Hits = safeHits;
            AtBats = safeAtbats;

        }
    }
}