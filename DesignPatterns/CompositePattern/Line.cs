using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Line : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("A line was drawn");
        }
    }
}
