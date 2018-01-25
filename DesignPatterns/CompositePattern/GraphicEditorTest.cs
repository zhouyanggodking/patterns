using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class GraphicEditorTest
    {
        static void Main(string[] args)
        {
            Graphic line = new Line();
            Graphic circle = new Circle();

            Graphic pic = new Picture();
            pic.Add(line);
            pic.Add(line);
            pic.Add(circle);

            //uniform invoke interface - transparency
            line.Draw();
            circle.Draw();
            pic.Draw();

        }
        
    }
}
