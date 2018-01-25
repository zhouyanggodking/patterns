#include "stdafx.h"
#include "CThirdPartyArm.h"
#include <iostream>


CThirdPartyArm::CThirdPartyArm(const std::string& material)
	: type(material)
{
}


CThirdPartyArm::~CThirdPartyArm()
{
}

void CThirdPartyArm::print()const
{
	std::cout << "Third Party Arm: " << type << std::endl;
}
