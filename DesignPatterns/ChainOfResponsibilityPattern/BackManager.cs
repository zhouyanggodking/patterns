using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class BackManager : Manager
    {
        public override void ProcessVocationRequest(VocationRequest request)
        {
            Console.WriteLine(string.Format("Sorry, {0}'s vocation request can not be processed: leave request days are {1}", request.Name, request.LeaveDays));
        }
    }
}
