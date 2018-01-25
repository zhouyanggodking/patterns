using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortAlgorithms
{
    public class BubbleSortStrategy : SortStrategy
    {
        public override void Sort()
        {
            Console.WriteLine("Bubble sort alogrithm");
        }
    }
}
