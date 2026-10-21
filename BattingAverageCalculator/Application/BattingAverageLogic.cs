using System;
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
            // Round to match the displayed average so values between the flair ranges still match one
            Flair = battingAverageDataAccess.GetFlair(Math.Round(CalculatedAverage, 3, MidpointRounding.AwayFromZero));
        }


    }
}
