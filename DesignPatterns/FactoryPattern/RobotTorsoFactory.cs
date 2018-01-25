using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class RobotTorsoFactory : IRobotComponentFactory
    {
        public IRobotComponent CreateRobotComponent(string type)
        {
            return new Torso() { TorsoType = type };
        }
    }
}
