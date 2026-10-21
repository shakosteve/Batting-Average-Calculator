using System.Collections.Generic;
using System.Linq;
using BattingAverageCalculator.Classes;
using BattingAverageCalculator.Properties;
using Newtonsoft.Json;

namespace BattingAverageCalculator.Data
{
    public class BattingAverageDataAccess
    {
        public List<Flair> Flair = JsonConvert.DeserializeObject<List<Flair>>(Resources.BattingAverageFlair);

        public string GetFlair(double average) => Flair.First(m => average <= m.Max && average >= m.Min).Flairtext;


    }
}
