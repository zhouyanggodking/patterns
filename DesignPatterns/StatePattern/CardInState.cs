using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CardInState : State
    {
        public override void Handle(Slot slot)
        {
            Console.WriteLine("Current state is Card in");
            slot.State = new PlayingState();
        }
    }
}
