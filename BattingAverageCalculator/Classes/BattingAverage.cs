namespace BattingAverageCalculator.Classes
{
    public class BattingAverage
    {
        public double AtBats { get; set; }
        public double Hits { get; set; }
        public string Average => $"{Hits / AtBats:.000}";
        public double CalculatedAverge => Hits / AtBats;
        public string Flair { get; set; }
    }
    
}
