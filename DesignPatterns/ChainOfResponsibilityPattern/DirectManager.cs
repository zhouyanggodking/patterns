using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class DirectManager : Manager
    {
        public DirectManager()
        {
            _processDays = 7;
            __managerTitle = "direct manager";
        }
    }
}
