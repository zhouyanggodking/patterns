using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Triangle : IShapeVisitable
    {
        public void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
