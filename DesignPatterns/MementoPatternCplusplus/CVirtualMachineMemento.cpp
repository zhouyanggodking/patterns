#include "stdafx.h"
#include "CVirtualMachineMemento.h"


CVirtualMachineMemento::CVirtualMachineMemento(const MachineState &machineState)
	:state(machineState)
{
}


CVirtualMachineMemento::~CVirtualMachineMemento()
{
}

MachineState CVirtualMachineMemento::getState()
{
	return state;
}
