using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            //string material = "Iron";
            //IRobotComponent arm = RobotArmFactory.Instance.CreateRobotComponent(material);
            //IRobotComponent leg = RobotLegFactory.Instance.CreateRobotComponent(material);
            //IRobotComponent torso = RobotTorsoFactory.Instance.CreateRobotComponent(material);
            //IRobotComponent head = RobotHeadFactory.Instance.CreateRobotComponent(material);

            //Arm armCopy = (Arm)(arm as Arm).Clone();
            //Leg legCopy = (Leg)(leg as Leg).Clone();
            //Torso torsoCopy = (Torso)(torso as Torso).Clone();
            //Head headCopy = (Head)(head as Head).Clone();

            //legCopy.LegType = "Copper";
            //headCopy.HeadType = "Golden";

            //arm.Display();
            //leg.Display();
            //torso.Display();
            //head.Display();

            //Console.WriteLine("++++++++++++++++++++++++");
            //armCopy.Display();
            
            //legCopy.Display();
            //torsoCopy.Display();
            //headCopy.Display();

            //Console.WriteLine("++++++++++++++++++++++++");

            //IRobotBuilder olderRobotBuilder = new OlderRobotBuilder();
            IRobotBuilder olderRobotBuilder = OlderRobotBuildFactory.Instance.CreateBuilder();
            RobotCreator robotCreator = new RobotCreator(olderRobotBuilder);
            Robot olderRobot = robotCreator.Create();
            Console.WriteLine(olderRobot);

            //IRobotBuilder grandNewRobotBuilder = new GrandNewGenerationRobotBuilder();
            IRobotBuilder grandNewRobotBuilder = GrandNewGenerationRobotBuilderFactory.Instance.CreateBuilder();
            robotCreator = new RobotCreator(grandNewRobotBuilder);
            Robot grandNewRobot = robotCreator.Create();
            Console.WriteLine(grandNewRobot);
        }
    }
}
