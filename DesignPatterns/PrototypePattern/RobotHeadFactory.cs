using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class RobotHeadFactory : IRobotComponentFactory
    {
        public IRobotComponent CreateRobotComponent(string type)
        {
            return new Head() { HeadType = type };
        }
    }
}
