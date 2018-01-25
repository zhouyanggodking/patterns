﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Studuent : Person
    {
        public Studuent(MessageBus messageBus)
            :base(messageBus)
        {
            Title = "Student";
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine(string.Format("{0} : {1} has sent the message : {2}", this.Name, this.Title, message));
            _messageBus.Dispatch(message);
        }

        public override void Notify(string message)
        {
            Console.WriteLine(string.Format("{0} : {1} has recieved the message : {2}", this.Name, this.Title, message));
        }
    }
}
