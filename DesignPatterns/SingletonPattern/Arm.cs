using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Arm : IRobotComponent, ICloneable
    {
        public string ArmType { get; set; }

        public void Display()
        {
            Console.WriteLine("Arm type: " + ArmType);
        }

        public object Clone()
        {
            //shallow or deep copy should you caution
            return this.MemberwiseClone();
        }
    }
}
