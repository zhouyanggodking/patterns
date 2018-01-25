using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class RobotArmFactory : IRobotComponentFactory
    {
        public IRobotComponent CreateRobotComponent(string type)
        {
            return new Arm() { ArmType = type };
        }
    }
}
