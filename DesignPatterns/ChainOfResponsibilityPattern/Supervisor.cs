using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Supervisor : Manager
    {
        public Supervisor()
        {
            _processDays = 30;
            __managerTitle = "supervisor";
        }
    }
}
