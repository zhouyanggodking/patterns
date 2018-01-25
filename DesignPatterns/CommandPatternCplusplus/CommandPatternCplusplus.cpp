// CommandPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CDisplayCommand.h"
#include "CArm.h"
#include <memory>


int _tmain(int argc, _TCHAR* argv[])
{
	std::string material("IRON");
	auto arm = std::make_shared<CArm>(material);

	auto displayCmd = std::make_shared<CDisplayCommand>(arm);

	displayCmd->execute();

	return 0;
}

