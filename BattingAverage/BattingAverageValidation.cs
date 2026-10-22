namespace BattingAverage
{
    public class BattingAverageValidation
    {
        public double Hits { get; set; }
        public double AtBats { get; set; }
        private const int DefaultAtBats = 550;


        public BattingAverageValidation(string hits, string atbats)
        {
            int parsedHits;
            int parsedAtbats;

            double safeHits = int.TryParse(hits, out parsedHits) ? parsedHits : 0;
            double safeAtbats = int.TryParse(atbats, out parsedAtbats) ? parsedAtbats : DefaultAtBats;

            safeAtbats = safeAtbats < 1 ? DefaultAtBats : safeAtbats;
            safeHits = safeHits > safeAtbats || safeHits < 1 ? 0 : safeHits;

            Hits = safeHits;
            AtBats = safeAtbats;

        }
    }
}