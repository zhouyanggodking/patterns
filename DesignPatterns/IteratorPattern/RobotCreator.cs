using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class RobotCreator
    {
        private IRobotBuilder _builder;

        public RobotCreator(IRobotBuilder builder)
        {
            this._builder = builder;
        }

        public Robot Create()
        {
            _builder.BuildArm();
            _builder.BuildHead();
            _builder.BuildLeg();
            _builder.BuildTorso();
            return _builder.GetRobot();
        }
    }
}
