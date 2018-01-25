using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class VirtualMachine
    {
        private MachineState _state;

        public void SetMachineState(MachineState state)
        {
            _state = state;
        }

        public MachineState GetMachineState()
        {
            return _state;
        }

        public VirtualMachineMemento SaveMachineStateIntoMemento()
        {
            Console.WriteLine("Saving current state into memento, current state: " + _state.ToString());
            return new VirtualMachineMemento(_state);
        }

        public MachineState RestoreFromMemento(VirtualMachineMemento memento)
        {            
            _state = memento.GetState();
            Console.WriteLine(string.Format("Restored to state: {0}", _state));
            return _state;
        }

        public void Display()
        {
            Console.WriteLine(string.Format("Virtual machine's current state: {0}", _state.ToString()));
        }
    }

    public enum MachineState
    {
        ShutDown,
        Starting,
        Started,
        Suspended,
        Running,
        ShutingDown
    }
}
