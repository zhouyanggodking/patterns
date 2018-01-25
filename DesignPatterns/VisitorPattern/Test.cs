using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            CalculateAreaVisitor areaVisitor = new CalculateAreaVisitor();
            circle.Accept(areaVisitor);
        }
    }
}
