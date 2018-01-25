using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Slot
    {
        public State State { get; set; }

        public Slot(State state)
        {
            this.State = state;
        }

        public void RequestStatus()
        {
            State.Handle(this);
        }
    }
}
