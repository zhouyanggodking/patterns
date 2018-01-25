// FactoryMethodCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CArm.h"
#include "CArmFactory.h"
#include <memory>


int _tmain(int argc, _TCHAR* argv[])
{
	std::string material("IRON");

	shared_ptr<CArmFactory> armFac(new CArmFactory);

	shared_ptr<IRobotComponent> armComponent = armFac->create(material);

	armComponent->display();



	return 0;
}

