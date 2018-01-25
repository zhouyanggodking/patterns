#pragma once
#include "IRobotComponentFactory.h"
class CTorsorFactory :
	public IRobotComponentFactory
{
public:
	CTorsorFactory();
	virtual ~CTorsorFactory();
	virtual shared_ptr<IRobotComponent> create(const std::string &material);
};

