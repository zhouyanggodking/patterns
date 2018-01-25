using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Teacher: IFans
    {
        public string Name { get; set; }
        private string _title = "Teacher";
        protected string Title { get { return _title; } }
        

        public void Update(WeiboMessage message)
        {
            Console.WriteLine("===========================");
            Console.WriteLine(string.Format("Name: {0} Title: {1} has recieved a new message from {2}. - {3}", Name, Title, message.FormName, message.State));
            Console.WriteLine(message.Message);
            Console.WriteLine("===========================");
        }
    }
}
