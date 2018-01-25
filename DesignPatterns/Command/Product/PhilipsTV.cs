using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Product
{
    public class PhilipsTV : TV
    {
        public override void Display()
        {
            Console.WriteLine("Philips TV: display current channel");
        }

        public override void MoveNext()
        {
            Console.WriteLine("Philips TV: move to next channel");
        }

        public override void MovePrevious()
        {
            Console.WriteLine("Philips TV: move to previous channel");
        }
    }
}
