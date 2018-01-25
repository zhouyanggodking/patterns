using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Leg : IRobotComponent, ICloneable
    {
        public string LegType { get; set; }

        public void Display()
        {
            Console.WriteLine("Leg Type: " + LegType);
        }

        public object Clone()
        {
            //shallow or deep copy should you caution
            return this.MemberwiseClone();
        }
    }
}
