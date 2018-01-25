using StrategyPattern.SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortStrategy sortAlg = new BubbleSortStrategy();

            NumberList numList = new NumberList(sortAlg);

            numList.Sort();
        }
    }
}
