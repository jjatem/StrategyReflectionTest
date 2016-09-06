using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyInterface;

namespace AccurintStrategy
{
    public class AccurintStrategy : iStrategy
    {
        public string strategy_name { get; set; }

        public AccurintStrategy()
        {
            this.strategy_name = "Accurint";
        }
        public AccurintStrategy(string name)
        {
            this.strategy_name = name;
        }

        public string GetDocument(string strategy_name)
        {
            return "Got Document from Accurint ACC Strategy implementation";
        }

        public string SaveDocument(string strategy_name)
        {
            return "Saved Document from Accurint Strategy implementation";
        }
    }
}
