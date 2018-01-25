using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Head : IRobotComponent
    {
        public string HeadType { get; set; }

        public void Display()
        {
            Console.WriteLine("Head type: " + HeadType);
        }
    }
}
