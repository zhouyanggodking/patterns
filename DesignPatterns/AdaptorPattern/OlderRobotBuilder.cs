using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    public class OlderRobotBuilder : IRobotBuilder
    {
        private Robot _robot;

        public OlderRobotBuilder()
        {
            _robot = new Robot();
        }

        public void BuildArm()
        {
            _robot.RobotArm = (Arm) RobotArmFactory.Instance.CreateRobotComponent("Older plain iron");
        }

        public void BuildLeg()
        {
            _robot.RobotLeg = (Leg)RobotLegFactory.Instance.CreateRobotComponent("Older plain iron");
        }

        public void BuildHead()
        {
            _robot.RobotHead = (Head)RobotHeadFactory.Instance.CreateRobotComponent("Older plain iron");
        }

        public void BuildTorso()
        {
            _robot.RobotTorso = (Torso)RobotTorsoFactory.Instance.CreateRobotComponent("Older plain iron");
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
