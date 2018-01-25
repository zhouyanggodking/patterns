using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Test
    {
        static void Main(string[] args)
        {
            string material = "Iron";
            IRobotComponent arm = new RobotArmFactory().CreateRobotComponent(material);
            IRobotComponent leg = new RobotLegFactory().CreateRobotComponent(material);
            IRobotComponent torso = new RobotTorsoFactory().CreateRobotComponent(material);
            IRobotComponent head = new RobotHeadFactory().CreateRobotComponent(material);

            Arm armCopy = (Arm)(arm as Arm).Clone();
            Leg legCopy = (Leg)(leg as Leg).Clone();
            Torso torsoCopy = (Torso)(torso as Torso).Clone();
            Head headCopy = (Head)(head as Head).Clone();

            legCopy.LegType = "Copper";
            headCopy.HeadType = "Golden";

            arm.Display();
            leg.Display();
            torso.Display();
            head.Display();

            Console.WriteLine("++++++++++++++++++++++++");
            armCopy.Display();
            
            legCopy.Display();
            torsoCopy.Display();
            headCopy.Display();
        }
    }
}
