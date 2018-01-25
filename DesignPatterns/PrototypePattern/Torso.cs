using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Torso : IRobotComponent, ICloneable
    {
        public string TorsoType { get; set; }

        public void Display()
        {
            Console.WriteLine("Torso type: " + TorsoType);
        }

        public object Clone()
        {
            //shallow or deep copy should you caution
            return this.MemberwiseClone();
        }
    }
}
