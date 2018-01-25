using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Product
{
    public class SonyTV : TV
    {
        public override void Display()
        {
            Console.WriteLine("Sony TV: display current channel");
        }

        public override void MoveNext()
        {
            Console.WriteLine("Sony TV: move to next channel");
        }

        public override void MovePrevious()
        {
            Console.WriteLine("Sony TV: move to previous channel");
        }
    }
}
