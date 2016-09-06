using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyInterface
{
    public interface iStrategy
    {
        string strategy_name { get; set; }

        string GetDocument(string stategy_name);
        string SaveDocument(string strategy_name);
    }
}
