#pragma once
#include "ICommand.h"
#include <memory>
class IRobotComponent;
class CDisplayCommand :
	public ICommand
{
public:
	CDisplayCommand(std::shared_ptr<IRobotComponent> robotComponent);
	virtual ~CDisplayCommand();
	virtual void execute()const;

private:
	std::shared_ptr<IRobotComponent> comp;
};

