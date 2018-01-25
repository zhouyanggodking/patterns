using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class IdleState : State
    {
        public override void Handle(Slot slot)
        {
            Console.WriteLine("Current state is idle");
            slot.State = new CardInState();
        }
    }
}
