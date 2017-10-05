using BattingAverageCalculator.Classes;
using BattingAverageCalculator.Data;

namespace BattingAverageCalculator.Application
{
    
    public class BattingAverageLogic : BattingAverage
    {
        public BattingAverageLogic(double hits, double atbats)
        {
            var battingAverageDataAccess = new BattingAverageDataAccess();
            AtBats = atbats;
            Hits = hits;
            Flair = battingAverageDataAccess.GetFlair(CalculatedAverge);
        }


    }
}
