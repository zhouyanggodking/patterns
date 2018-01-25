using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Arm : IRobotComponent
    {
        public string ArmType { get; set; }

        public void Display()
        {
            Console.WriteLine("Arm type: " + ArmType);
        }
    }
}
