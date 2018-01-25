using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class OlderRobotBuildFactory : IRobotBuilderFactory
    {
        private static OlderRobotBuildFactory _instance = null;
        private OlderRobotBuildFactory()
        {
        }

        public static OlderRobotBuildFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OlderRobotBuildFactory();
                return _instance;
            }
        }

        public IRobotBuilder CreateBuilder()
        {
            return new OlderRobotBuilder();
        }
    }
}
