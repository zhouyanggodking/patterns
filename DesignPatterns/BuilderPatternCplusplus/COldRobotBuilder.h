#pragma once
#include "stdafx.h"
#include "CBuilder.h"
class COldRobotBuilder :
	public CBuilder
{
public:
	COldRobotBuilder();
	~COldRobotBuilder();
	virtual void buildArm();
	virtual void buildHead();
	virtual void buildLeg();
	virtual void buildTorso();
	virtual shared_ptr<CRobot> getRobot();
private:
	shared_ptr<CRobot> robot;
	string material;
};

