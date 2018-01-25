using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class PlayingState : State
    {
        public override void Handle(Slot slot)
        {
            Console.WriteLine("Current state is on playing");
            slot.State = new CardOutState();
        }
    }
}
