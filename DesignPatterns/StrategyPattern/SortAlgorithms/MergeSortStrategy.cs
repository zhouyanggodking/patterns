using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortAlgorithms
{
    public class MergeSortStrategy : SortStrategy
    {
        public override void Sort()
        {
            Console.WriteLine("Merge sort Algorithm");
        }
    }
}
