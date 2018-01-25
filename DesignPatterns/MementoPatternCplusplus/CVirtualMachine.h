#pragma once

#include <memory>
class CVirtualMachineMemento;

enum class MachineState
{
	PoweredOff,
	Suspended,
	Running
};

class CVirtualMachine
{
public:
	CVirtualMachine();
	~CVirtualMachine();
	void setState(const MachineState& machineState);
	std::shared_ptr<CVirtualMachineMemento> SaveCurrentState();
	void RestoreFromState(std::shared_ptr<CVirtualMachineMemento>);
	void display()const;
private:
	MachineState state;
};

std::string map_enum_to_string(const MachineState& state);
