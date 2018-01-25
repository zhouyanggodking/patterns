using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeiboMessage
    {
        public WeiboState State { get; set; }
        public string  FormName { get; set; }
        public string Message { get; set; }

        public enum WeiboState
        {
            Added,
            Updated,
            Deleted
        }
    }
}
