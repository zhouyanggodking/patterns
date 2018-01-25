#pragma once
#include "IRobotComponentFactory.h"
class CArmFactory :
	public IRobotComponentFactory
{
public:
	CArmFactory();
	virtual ~CArmFactory();
	// the return type must be shared_ptr<IRobotComponent> instead of shared_ptr<CArm>
	virtual shared_ptr<IRobotComponent> create(const std::string &material);
};

