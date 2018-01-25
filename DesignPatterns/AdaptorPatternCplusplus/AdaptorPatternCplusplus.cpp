// AdaptorPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CArm.h"
#include "CThirdPartyArm.h"
#include "CThirdPartyArmAdaptor.h"
#include "IRobotComponent.h"

#include <memory>

void processRobotComponent(const IRobotComponent &robotComponent)
{
	robotComponent.display();
}


int _tmain(int argc, _TCHAR* argv[])
{
	std::string material("Third party material");
	std::shared_ptr<CThirdPartyArm> otherArm(new CThirdPartyArm{ material });

	CThirdPartyArmAdaptor thirdPartyArmAdaptor(otherArm);

	//how to use processRobotComponent to fit third party arm print()
	processRobotComponent(thirdPartyArmAdaptor);

	return 0;
}

