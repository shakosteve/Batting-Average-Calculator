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

        public string GetFlair(double averge) => Flair.First(m => averge <= m.Max && averge >= m.Min).Flairtext;


    }
}
