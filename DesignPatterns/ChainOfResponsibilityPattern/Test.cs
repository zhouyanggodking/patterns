using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            ProcessBlackBox(new VocationRequest() { LeaveDays = 3, Name = "God" });
            ProcessBlackBox(new VocationRequest() { LeaveDays = 28, Name = "King" });
            ProcessBlackBox(new VocationRequest() { LeaveDays = 300, Name = "Ocean" });
            ProcessBlackBox(new VocationRequest() { LeaveDays = 600, Name = "Sky" });
        }

        static void ProcessBlackBox(VocationRequest request)
        {
            var directMgr = new DirectManager();
            var supervisor = new Supervisor();
            var director = new ManagerDirector();
            var backMgr = new BackManager();

            directMgr.SetSuccessor(supervisor);
            supervisor.SetSuccessor(director);
            director.SetSuccessor(backMgr);

            directMgr.ProcessVocationRequest(request);
        }
    }
}
