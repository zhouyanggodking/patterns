using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class RobotHeadFactory : IRobotComponentFactory
    {
        public IRobotComponent CreateRobotComponent(string type)
        {
            return new Head() { HeadType = type };
        }
    }
}
