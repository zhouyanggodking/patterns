#pragma once
#include "CRobot.h"
#include <memory>

using std::shared_ptr;

class CBuilder
{
public:
	CBuilder();
	virtual ~CBuilder() = 0;
	
	virtual void buildArm() = 0;
	virtual void buildHead() = 0;
	virtual void buildLeg() = 0;
	virtual void buildTorso() = 0;
	virtual shared_ptr<CRobot> getRobot() = 0;
};

