using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            string material = "Iron";
            var arm = new RobotArmFactory().CreateRobotComponent(material);
            var leg = new RobotLegFactory().CreateRobotComponent(material);
            var torso = new RobotTorsoFactory().CreateRobotComponent(material);
            var head = new RobotHeadFactory().CreateRobotComponent(material);
            arm.Display();
            leg.Display();
            torso.Display();
            head.Display();
        }
    }
}
