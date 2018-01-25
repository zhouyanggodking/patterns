// PrototypePatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "CArm.h"
#include "IClonable.h"
#include <memory>


int _tmain(int argc, _TCHAR* argv[])
{
	std::string material("IRON");
	std::shared_ptr<CArm> armPtr(new CArm{ material });

	return 0;
}

