#include "stdafx.h"
#include "CThirdPartyArmAdaptor.h"
#include "CThirdPartyArm.h"


CThirdPartyArmAdaptor::CThirdPartyArmAdaptor(std::shared_ptr<CThirdPartyArm> otherArm)
	: pArm(otherArm)
{
}


CThirdPartyArmAdaptor::~CThirdPartyArmAdaptor()
{
}


void CThirdPartyArmAdaptor::display()const
{
	pArm->print();
}