using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern
{
    //MessageBus recieves message from clients and dispatch to somebody
    public abstract class MessageBus
    {
        public abstract void Dispatch(string message);
    }
}
