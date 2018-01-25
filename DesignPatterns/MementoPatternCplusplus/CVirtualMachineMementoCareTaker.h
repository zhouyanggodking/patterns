#pragma once

#include <memory>
#include <stack>
#include "CVirtualMachineMemento.h"

class CVirtualMachineMementoCareTaker
{
public:
	CVirtualMachineMementoCareTaker();
	~CVirtualMachineMementoCareTaker();
	void pushMemento(std::shared_ptr<CVirtualMachineMemento>);
	std::shared_ptr<CVirtualMachineMemento> popMemento();

private:
	std::stack<std::shared_ptr<CVirtualMachineMemento> > mementoStack;
};

