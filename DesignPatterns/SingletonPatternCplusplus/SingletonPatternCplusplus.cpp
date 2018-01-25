// SingletonPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CArm.h"

#include "SingletonRobotComponentCreator.hpp"
#include <memory>
#include "CHead.h"
#include "CTorso.h"


int _tmain(int argc, _TCHAR* argv[])
{
	std::string material("IRON");

	auto creator = SingletonRobotComponentCreator<CArm>::getInstance();
	std::shared_ptr<CArm> arm = creator->create(material);
	arm->display();
	auto creator2 = SingletonRobotComponentCreator<CArm>::getInstance();
	auto arm2 = creator2->create("GOLDEN");
	arm2->display();

	auto creator3 = SingletonRobotComponentCreator<CHead>::getInstance();
	auto head = creator3->create("Silver");
	head->display();

	//using template method instead of factory class
	auto torso = create<CTorso>("Titanium");
	torso->display();

	return 0;
}

