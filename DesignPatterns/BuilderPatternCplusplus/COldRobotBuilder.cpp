#include "stdafx.h"
#include "COldRobotBuilder.h"
#include "CRobot.h"


COldRobotBuilder::COldRobotBuilder()
	:material("Iron"), robot(new CRobot)
{
}


COldRobotBuilder::~COldRobotBuilder()
{
}


void COldRobotBuilder::buildArm()
{
	material = "Iron";
	robot->setArm(new CArm(material));
}

void COldRobotBuilder::buildHead()
{
	material = "Bronze";
	robot->setHead(new CHead(material));
}

void COldRobotBuilder::buildLeg()
{
	material = "Bronze";
	robot->setLeg(new CLeg(material));
}

void COldRobotBuilder::buildTorso()
{
	material = "Silver";
	robot->setTorso(new CTorso(material));
}

shared_ptr<CRobot> COldRobotBuilder::getRobot()
{
	return robot;
}