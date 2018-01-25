#include "stdafx.h"
#include "CArmFactory.h"
#include "CArm.h"


CArmFactory::CArmFactory()
{
}


CArmFactory::~CArmFactory()
{
}

shared_ptr<IRobotComponent> CArmFactory::create(const std::string&material)
{
	return shared_ptr<IRobotComponent>(new CArm{ material });
}
