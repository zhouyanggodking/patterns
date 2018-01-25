using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class RobotHeadFactory : IRobotComponentFactory
    {
        private static RobotHeadFactory _instance = null;

        private RobotHeadFactory()
        {

        }


        public static RobotHeadFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RobotHeadFactory();
                return _instance;
            }
        }

        public IRobotComponent CreateRobotComponent(string type)
        {
            return new Head() { HeadType = type };
        }
    }
}
