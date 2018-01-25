using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface IRobotBuilder
    {
        void BuildArm();
        void BuildLeg();
        void BuildHead();
        void BuildTorso();
        Robot GetRobot();
    }
}
