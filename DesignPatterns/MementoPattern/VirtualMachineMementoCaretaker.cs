using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class VirtualMachineMementoCaretaker
    {
        private Stack<VirtualMachineMemento> _mementoStack = new Stack<VirtualMachineMemento>();

        public void AddMemento(VirtualMachineMemento memento)
        {
            _mementoStack.Push(memento);
        }

        public VirtualMachineMemento GetMemento()
        {
            return _mementoStack.Pop();
        }
    }
}
