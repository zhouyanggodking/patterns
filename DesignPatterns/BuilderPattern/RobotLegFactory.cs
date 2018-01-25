using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class RobotLegFactory : IRobotComponentFactory
    {
        private static RobotLegFactory _instance = null;

        private RobotLegFactory()
        {

        }

        public static RobotLegFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RobotLegFactory();
                return _instance;
            }
        }

        public IRobotComponent CreateRobotComponent(string type)
        {
            return new Leg() { LegType = type };
        }
    }
}
