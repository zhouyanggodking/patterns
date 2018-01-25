using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IWeiboMessageSource
    {
        void AddFans(IFans fans);
        bool RemoveFans(IFans fans);
        void Notify();
    }

    
}
