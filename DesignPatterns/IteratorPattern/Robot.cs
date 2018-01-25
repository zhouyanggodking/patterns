using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Robot : IWeapon, ICloneable
    {
        public Arm RobotArm { get; set; }
        public Leg RobotLeg { get; set; }
        public Head RobotHead { get; set; }
        public Torso RobotTorso { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Arm: {1}, Leg: {2}, Head: {3}, Torso: {4}", Name, RobotArm.ArmType,
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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
