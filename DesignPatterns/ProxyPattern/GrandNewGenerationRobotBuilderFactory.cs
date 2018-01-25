using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class GrandNewGenerationRobotBuilderFactory : IRobotBuilderFactory
    {
        private static GrandNewGenerationRobotBuilderFactory _instance = null;
        private GrandNewGenerationRobotBuilderFactory()
        {
        }

        public static GrandNewGenerationRobotBuilderFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GrandNewGenerationRobotBuilderFactory();
                return _instance;
            }
        }

        public IRobotBuilder CreateBuilder()
        {
            return new GrandNewGenerationRobotBuilder();
        }
    }
}
