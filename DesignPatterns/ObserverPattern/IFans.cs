using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    public interface IFans
    {
        void Update(WeiboMessage message);
    }
}
