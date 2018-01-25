#pragma once
#include "IRobotComponent.h"
#include <memory>
class CThirdPartyArm;
class CThirdPartyArmAdaptor : public IRobotComponent
{
public:
	CThirdPartyArmAdaptor(std::shared_ptr<CThirdPartyArm> otherArm);
	~CThirdPartyArmAdaptor();
	virtual void display()const;
private:
	std::shared_ptr<CThirdPartyArm> pArm;
};

