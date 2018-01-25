using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public abstract class Graphic
    {
        public virtual void Add(Graphic g)
        {
            throw new NotSupportedException("Not supported");
        }
        public virtual bool Remove(Graphic g)
        {
            throw new NotSupportedException("Not supported");
        }
        public virtual Graphic GetChild(int index)
        {
            return null;
        }

        public abstract void Draw();        
    }
}
