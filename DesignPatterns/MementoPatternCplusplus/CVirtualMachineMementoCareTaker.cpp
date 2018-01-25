#include "stdafx.h"
#include "CVirtualMachineMementoCareTaker.h"


CVirtualMachineMementoCareTaker::CVirtualMachineMementoCareTaker()
	:mementoStack()
{
}


CVirtualMachineMementoCareTaker::~CVirtualMachineMementoCareTaker()
{
}


void CVirtualMachineMementoCareTaker::pushMemento(std::shared_ptr<CVirtualMachineMemento> memento)
{
	mementoStack.push(memento);
}


std::shared_ptr<CVirtualMachineMemento> CVirtualMachineMementoCareTaker::popMemento()
{
	auto temp = mementoStack.top();
	mementoStack.pop();
	return temp;
}
