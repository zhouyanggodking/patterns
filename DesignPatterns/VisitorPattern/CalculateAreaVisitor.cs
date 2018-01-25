using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class CalculateAreaVisitor : IShapeVisitor
    {
        public void Visit(Triangle triangle)
        {
            Console.WriteLine("Calculating triangle's area");
        }

        public void Visit(Rectangle rectangle)
        {
            Console.WriteLine("Calculating rectangle's area");
        }

        public void Visit(Circle circle)
        {
            Console.WriteLine("Calculating circle's area");
        }
    }
}
