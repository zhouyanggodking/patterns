using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern
{
    public interface IShapeVisitor
    {
        //couple to each elements in IVisitable
        //That is why it nees elements hierarchy to be extreamly stable
        void Visit(Triangle triangle);
        void Visit(Rectangle rectangle);
        void Visit(Circle circle);
    }
}
