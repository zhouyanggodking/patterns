using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    public class RobotArmFactory : IRobotComponentFactory
    {
        private static RobotArmFactory _instance = null;

        private RobotArmFactory()
        {

        }

        public static RobotArmFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RobotArmFactory();
                return _instance;
            }
        }

        public IRobotComponent CreateRobotComponent(string type)
        {
            return new Arm() { ArmType = type };
        }
    }
}
