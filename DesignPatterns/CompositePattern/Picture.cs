using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Picture : Graphic
    {
        private List<Graphic> _graphicList = new List<Graphic>();

        public override void Add(Graphic g)
        {
            _graphicList.Add(g);
        }

        public override bool Remove(Graphic g)
        {
            _graphicList.Remove(g);
            return true;
        }
        public override Graphic GetChild(int index)
        {
            if(index > 0 && index < _graphicList.Count)
                return _graphicList[index];
            return null;
        }

        public override void Draw()
        {
            foreach (var g in _graphicList)
                g.Draw();
        }
    }
}
