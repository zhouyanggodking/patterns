// BuilderPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CArm.h"
#include "CHead.h"
#include "CLeg.h"
#include "CTorso.h"
#include "CRobot.h"
#include "CBuilder.h"
#include "CGrandNewGenerationRobotBuilder.h"
#include "COldRobotBuilder.h"
#include "CRobotCreator.h"

using std::endl;
using std::cout;

int _tmain(int argc, _TCHAR* argv[])
{
	shared_ptr<CBuilder> grandNewRobotBuilder(new CGrandNewGenerationRobotBuilder());

	shared_ptr<CRobotCreator> grandNewRobotCreator(new CRobotCreator(grandNewRobotBuilder));

	shared_ptr<CRobot> newRobot = grandNewRobotCreator->createRobot();

	cout << *newRobot << endl;

	shared_ptr<CBuilder> olderBuilder(new COldRobotBuilder);
	shared_ptr<CRobotCreator> oldRobotCreator(new CRobotCreator(olderBuilder));
	shared_ptr<CRobot> oldRobot = oldRobotCreator->createRobot();
	cout << *oldRobot << endl;

	return 0;
}

