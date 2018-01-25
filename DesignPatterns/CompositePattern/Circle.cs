using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Circle : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("A circle was drawn");
        }
    }
}
