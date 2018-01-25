using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Head : IRobotComponent, ICloneable
    {
        public string HeadType { get; set; }

        public void Display()
        {
            Console.WriteLine("Head type: " + HeadType);
        }

        public object Clone()
        {
            //shallow or deep copy should you caution
            return this.MemberwiseClone();
        }
    }
}
