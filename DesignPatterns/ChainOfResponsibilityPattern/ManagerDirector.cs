using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class ManagerDirector : Manager
    {
        public ManagerDirector()
        {
            _processDays = 365;
            __managerTitle = "director";
        }
    }
}
