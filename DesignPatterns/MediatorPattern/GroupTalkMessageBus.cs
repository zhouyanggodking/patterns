using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //MessageBus recieves message from clients and dispatch to everyone
    public class GroupTalkMessageBus : MessageBus
    {
        private List<Person> _involvedPersonList = new List<Person>();

        public void Join(Person person)
        {
            _involvedPersonList.Add(person);
            Console.WriteLine(string.Format("{0} : {1} has joined the talk", person.Name, person.Title));
        }

        public override void Dispatch(string message)
        {
            foreach (var person in _involvedPersonList)
                person.Notify(message);
        }
    }
}
