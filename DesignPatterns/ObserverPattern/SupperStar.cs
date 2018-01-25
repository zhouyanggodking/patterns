using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class SupperStar: IWeiboMessageSource
    {
        private List<IFans> _fansList = new List<IFans>();
        private WeiboMessage _weiboMessage;

        public string Name { get; set; }

        public SupperStar(string name)
        {
            Name = name;
            _weiboMessage = new WeiboMessage() { FormName = name };
        }

        public void UpdateWeiboMessage(string message)
        {
            _weiboMessage.Message = message;
            _weiboMessage.State = WeiboMessage.WeiboState.Updated;
        }

        public void AddWeiboMessage(string message)
        {
            _weiboMessage.Message = message;
            _weiboMessage.State = WeiboMessage.WeiboState.Added;
        }
        public void AddFans(IFans fans)
        {
            _fansList.Add(fans);
        }

        public bool RemoveFans(IFans fans)
        {
            return _fansList.Remove(fans);
        }

        public void Notify()
        {
            foreach(var fans in _fansList)
            {
                fans.Update(_weiboMessage);
            }
        }
    }
}
