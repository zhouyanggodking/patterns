// MementoPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include <memory>
#include "CVirtualMachine.h"
#include "CVirtualMachineMemento.h"
#include "CVirtualMachineMementoCareTaker.h"


int _tmain(int argc, _TCHAR* argv[])
{
	auto vm = std::make_shared<CVirtualMachine>();//powered off

	auto careTaker = std::make_shared<CVirtualMachineMementoCareTaker>();

	auto memento = vm->SaveCurrentState();

	careTaker->pushMemento(memento);

	vm->setState(MachineState::Running); //running

	careTaker->pushMemento(vm->SaveCurrentState());

	vm->setState(MachineState::Suspended);//suspended

	//careTaker->pushMemento(vm->SaveCurrentState());

	vm->display();

	std::cout << "Restoring previous state..." << std::endl;

	vm->RestoreFromState(careTaker->popMemento());
	vm->display();

	return 0;
}

