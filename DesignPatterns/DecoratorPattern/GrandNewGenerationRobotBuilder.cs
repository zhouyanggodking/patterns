using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class GrandNewGenerationRobotBuilder : IRobotBuilder
    {
        private Robot _robot;

        public GrandNewGenerationRobotBuilder()
        {
            _robot = new Robot();
        }

        public void BuildArm()
        {
            _robot.RobotArm = (Arm)RobotArmFactory.Instance.CreateRobotComponent("Grand new golden");
        }

        public void BuildLeg()
        {
            _robot.RobotLeg = (Leg)RobotLegFactory.Instance.CreateRobotComponent("White Silver");
        }

        public void BuildHead()
        {
            _robot.RobotHead = (Head)RobotHeadFactory.Instance.CreateRobotComponent("Titanium");
        }

        public void BuildTorso()
        {
            _robot.RobotTorso = (Torso)RobotTorsoFactory.Instance.CreateRobotComponent("Copper");
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
