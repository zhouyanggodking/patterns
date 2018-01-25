using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortAlgorithms
{
    public class HeapSortStrategy : SortStrategy
    {
        public override void Sort()
        {
            Console.WriteLine("Heap sort algorithm");
        }
    }
}
