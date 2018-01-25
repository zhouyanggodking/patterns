using StrategyPattern.SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class NumberList
    {
        private SortStrategy _sortAlgorithm;

        public NumberList(SortStrategy sortStrategy)
        {
            this._sortAlgorithm = sortStrategy;
        }

        public void Sort()
        {
            this._sortAlgorithm.Sort();
        }
    }
}
