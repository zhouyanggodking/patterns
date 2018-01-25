#pragma once
#include "CBuilder.h"
#include "CRobot.h"
#include <memory>

using std::shared_ptr;

class CRobotCreator
{
public:
	CRobotCreator(shared_ptr<CBuilder> robotBuilder);
	~CRobotCreator();
	shared_ptr<CRobot> createRobot();
private:
	shared_ptr<CBuilder> builder;
};

