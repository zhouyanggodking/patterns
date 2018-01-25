#pragma once
#include <memory>

enum class MachineState;
class CVirtualMachineMemento
{
public:
	CVirtualMachineMemento(const MachineState &machineState);
	~CVirtualMachineMemento();
	MachineState getState();
	//void setState(const MachineState&);
private:
	MachineState state;
};

