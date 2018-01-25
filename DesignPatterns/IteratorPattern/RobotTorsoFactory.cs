using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class RobotTorsoFactory : IRobotComponentFactory
    {
        private static RobotTorsoFactory _instance = null;

        private RobotTorsoFactory()
        {

        }

        public static RobotTorsoFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RobotTorsoFactory();
                return _instance;
            }
        }

        public IRobotComponent CreateRobotComponent(string type)
        {
            return new Torso() { TorsoType = type };
        }
    }
}
