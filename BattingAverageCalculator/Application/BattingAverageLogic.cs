using System;
using BattingAverageCalculator.Classes;
using BattingAverageCalculator.Data;

namespace BattingAverageCalculator.Application
{
    
    public class BattingAverageLogic : BattingAverage
    {
        private const double ApplauseMinimum = 0.200;
        private const double ApplauseMaximum = 0.270;

        public BattingAverageLogic(double hits, double atbats, BattingAverageDataAccess battingAverageDataAccess)
        {
            AtBats = atbats;
            Hits = hits;
            // Round to match the displayed average so values between the flair ranges still match one
            var roundedAverage = Math.Round(CalculatedAverage, 3, MidpointRounding.AwayFromZero);
            Flair = battingAverageDataAccess.GetFlair(roundedAverage);
            Reaction = roundedAverage < ApplauseMinimum ? CrowdReaction.Boo
                : roundedAverage <= ApplauseMaximum ? CrowdReaction.Applause
                : CrowdReaction.Cheer;
        }


    }
}
