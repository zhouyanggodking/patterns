using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            GroupTalkMessageBus groupTalk = new GroupTalkMessageBus();

            Studuent god = new Studuent(groupTalk) { Name = "God" };
            Teacher king = new Teacher(groupTalk) { Name = "King" };
            Professor ocean = new Professor(groupTalk) { Name = "Ocean" };
            Studuent sky = new Studuent(groupTalk) { Name = "Sky" };

            groupTalk.Join(god);
            groupTalk.Join(king);
            groupTalk.Join(ocean);
            groupTalk.Join(sky);


            god.SendMessage("Hello, everyone!");
            god.SendMessage("Welcome to group talk");


        }
    }
}
