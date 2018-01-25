using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public abstract class Manager
    {
        protected Manager _successor;
        protected int _processDays;
        protected string __managerTitle;

        public void SetSuccessor(Manager manager)
        {
            _successor = manager;
        }

        public virtual void ProcessVocationRequest(VocationRequest request)
        {
            if (request.LeaveDays < _processDays)
                Console.WriteLine(string.Format("{0}'s vocation request is process by his {1}, leave request days are {2} days", request.Name, __managerTitle, request.LeaveDays));
            else if(null != _successor)
            {
                _successor.ProcessVocationRequest(request);
            }
        }
    }
}
