using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Torso : IRobotComponent
    {
        public string TorsoType { get; set; }

        public void Display()
        {
            Console.WriteLine("Torso type: " + TorsoType);
        }
    }
}
