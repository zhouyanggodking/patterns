#include "stdafx.h"
#include "CHeadFactory.h"
#include "CHead.h"


CHeadFactory::CHeadFactory()
{
}


CHeadFactory::~CHeadFactory()
{
}


shared_ptr<IRobotComponent> CHeadFactory::create(const std::string &material)
{
	return shared_ptr<IRobotComponent>(new CHead{ material });
}