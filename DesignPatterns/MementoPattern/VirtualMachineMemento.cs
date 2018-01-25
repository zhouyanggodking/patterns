using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    public class VirtualMachineMemento
    {
        private MachineState _state;

        public VirtualMachineMemento(MachineState state)
        {
            // TODO: Complete member initialization
            this._state = state;
        }

        public MachineState GetState()
        {
            return _state;
        }

        public void SetState(MachineState state)
        {
            _state = state;
        }
    }
}
