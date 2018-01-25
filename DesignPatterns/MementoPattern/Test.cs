using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Test
    {
        static void Main(string[] args)
        {
            VirtualMachine vm = new VirtualMachine();
            vm.SetMachineState(MachineState.Running);
            vm.Display();


            //snapshot
            var memento = vm.SaveMachineStateIntoMemento();

            //add it into caretaker
            var caretaker = new VirtualMachineMementoCaretaker();
            caretaker.AddMemento(memento);

            //new state
            vm.SetMachineState(MachineState.ShutingDown);
            vm.Display();
            //snapshot again
            memento = vm.SaveMachineStateIntoMemento();
            caretaker.AddMemento(memento);
            

            //new state
            vm.SetMachineState(MachineState.ShutDown);
            vm.Display();


            //revert to previous saved state
            memento = caretaker.GetMemento();
            vm.RestoreFromMemento(memento);
            vm.Display();


            //revert to previous of previous

            memento = caretaker.GetMemento();
            vm.RestoreFromMemento(memento);
            vm.Display();
        }
    }
}
