// ObserverPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <memory>
#include "CSupperStar.h"
#include "CStudent.h"
#include "CTeacher.h"


int _tmain(int argc, _TCHAR* argv[])
{
	auto supperStar = std::make_shared<CSupperStar>();

	supperStar->addSub(std::make_shared<CStudent>());
	supperStar->addSub(std::make_shared<CTeacher>());

	supperStar->notify("Big goal");

	return 0;
}

