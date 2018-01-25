#include "stdafx.h"
#include "CGrandNewGenerationRobotBuilder.h"


CGrandNewGenerationRobotBuilder::CGrandNewGenerationRobotBuilder()
	: material("GOLDEN"), robot(new CRobot)
{
}


CGrandNewGenerationRobotBuilder::~CGrandNewGenerationRobotBuilder()
{
}


void CGrandNewGenerationRobotBuilder::buildArm()
{
	robot->setArm(new CArm(material));
}

void CGrandNewGenerationRobotBuilder::buildHead()
{
	robot->setHead(new CHead(material));
}

void CGrandNewGenerationRobotBuilder::buildLeg()
{
	robot->setLeg(new CLeg(material));
}

void CGrandNewGenerationRobotBuilder::buildTorso()
{
	robot->setTorso(new CTorso(material));
}

shared_ptr<CRobot> CGrandNewGenerationRobotBuilder::getRobot()
{
	return robot;
}

