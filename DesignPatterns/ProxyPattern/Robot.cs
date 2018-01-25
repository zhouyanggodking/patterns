using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Robot : IWeapon
    {
        public Arm RobotArm { get; set; }
        public Leg RobotLeg { get; set; }
        public Head RobotHead { get; set; }
        public Torso RobotTorso { get; set; }

        public override string ToString()
        {
            return string.Format("Arm: {0}, Leg: {1}, Head: {2}, Torso: {3}", RobotArm.ArmType,
                RobotLeg.LegType, RobotHead.HeadType, RobotTorso.TorsoType);
        }

        public void Move()
        {
            Console.WriteLine("Robot move...");
        }

        public void Destroy()
        {
            Console.WriteLine("Robot destroyed several targets...");
        }
    }
}
