using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyInterface;

namespace MBSiStrategy
{
    public class MBSiStrategy : iStrategy
    {
        public string strategy_name { get; set; }

        public MBSiStrategy()
        {
            this.strategy_name = "MBSi";
        }

        public MBSiStrategy(string name)
        {
            this.strategy_name = name;
        }


        public string GetDocument(string strategy_name)
        {
            return "Got Document from MBSi Strategy implementation";
        }

        public string SaveDocument(string strategy_name)
        {
            return "Saved Document from MBSi Strategy implementation";
        }
    }
}
