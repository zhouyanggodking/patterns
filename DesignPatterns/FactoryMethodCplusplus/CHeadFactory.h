#pragma once
#include "IRobotComponentFactory.h"
class CHeadFactory :
	public IRobotComponentFactory
{
public:
	CHeadFactory();
	virtual ~CHeadFactory();
	virtual shared_ptr<IRobotComponent> create(const std::string &material);
};

