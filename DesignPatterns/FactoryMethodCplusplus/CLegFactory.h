#pragma once
#include "IRobotComponentFactory.h"
class CLegFactory :
	public IRobotComponentFactory
{
public:
	CLegFactory();
	virtual ~CLegFactory();
	virtual shared_ptr<IRobotComponent> create(const std::string &material);
};

