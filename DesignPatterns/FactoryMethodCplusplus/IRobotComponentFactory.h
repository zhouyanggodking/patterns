#pragma once
#include <memory>
#include "IRobotComponent.h"


using std::shared_ptr;

class IRobotComponentFactory
{
public:
	IRobotComponentFactory();
	virtual ~IRobotComponentFactory()=0;
	virtual shared_ptr<IRobotComponent> create(const std::string &material) = 0;
};

