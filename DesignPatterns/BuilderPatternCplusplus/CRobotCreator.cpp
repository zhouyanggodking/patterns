#include "stdafx.h"
#include "CRobotCreator.h"


CRobotCreator::CRobotCreator(shared_ptr<CBuilder> robotBuilder)
	:builder(robotBuilder)
{
}


CRobotCreator::~CRobotCreator()
{
}

shared_ptr<CRobot> CRobotCreator::createRobot()
{
	builder->buildArm();
	builder->buildHead();
	builder->buildLeg();
	builder->buildTorso();
	return builder->getRobot();
}
