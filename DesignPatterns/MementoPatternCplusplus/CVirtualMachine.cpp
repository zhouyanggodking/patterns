#include "stdafx.h"
#include "CVirtualMachine.h"
#include "CVirtualMachineMemento.h"


CVirtualMachine::CVirtualMachine()
	:state(MachineState::PoweredOff)
{
}


CVirtualMachine::~CVirtualMachine()
{
}

void CVirtualMachine::setState(const MachineState& machineState)
{
	state = machineState;
}

std::shared_ptr<CVirtualMachineMemento> CVirtualMachine::SaveCurrentState()
{
	return std::make_shared<CVirtualMachineMemento>(state);
}

void CVirtualMachine::RestoreFromState(std::shared_ptr<CVirtualMachineMemento> memento)
{
	state = memento->getState();
}

void CVirtualMachine::display()const
{
	std::cout << "Current state: " << map_enum_to_string(state) << std::endl;
}

std::string map_enum_to_string(const MachineState& state)
{
	switch (state)
	{
	case MachineState::PoweredOff:
		return std::string("PoweredOff");
	case MachineState::Running:
		return std::string("Running");
	case MachineState::Suspended:
		return std::string("Suspended");
	default:
		break;
	}
}

