using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using StrategyInterface;

namespace StrategyReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {

            LoadAndExecuteMBSiStrategy();
            LoadAndExecuteAccurintStrategy();

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Press any enter to exit....");
            System.Console.ReadLine();

        }

        public static void LoadAndExecuteMBSiStrategy()
        {
            var MBSiStrategy = Activator.CreateInstance(AppDomain.CurrentDomain, "MBSiStrategy", "MBSiStrategy.MBSiStrategy");

            iStrategy myStrategy = (iStrategy)MBSiStrategy.Unwrap();

            System.Console.WriteLine(myStrategy.GetDocument("MBSiStrategy"));
            System.Console.WriteLine(myStrategy.SaveDocument("MBSiStrategy"));

        }

        public static void LoadAndExecuteAccurintStrategy()
        {
            var AccurintStrat = Activator.CreateInstance(AppDomain.CurrentDomain, "AccurintStrategy", "AccurintStrategy.AccurintStrategy");

            iStrategy myStrategy = (iStrategy)AccurintStrat.Unwrap();

            System.Console.WriteLine(myStrategy.GetDocument("AccurintStrategy"));
            System.Console.WriteLine(myStrategy.SaveDocument("AccurintStrategy"));

        }
    }
}
