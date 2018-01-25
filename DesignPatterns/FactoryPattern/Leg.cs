using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Leg : IRobotComponent
    {
        public string LegType { get; set; }

        public void Display()
        {
            Console.WriteLine("Leg Type: " + LegType);
        }
    }
}
