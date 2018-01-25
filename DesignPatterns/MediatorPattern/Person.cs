using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class Person
    {
        protected MessageBus _messageBus; //the mediator

        public string Name { get; set; }

        public string Title { get; protected set; }

        public Person(MessageBus messageBus)
        {
            this._messageBus = messageBus;
        }

        //send message
        public abstract void SendMessage(string message);

        //recieve message
        public abstract void Notify(string message);
    }
}
