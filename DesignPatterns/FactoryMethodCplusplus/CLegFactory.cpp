#include "stdafx.h"
#include "CLegFactory.h"
#include "CLeg.h"


CLegFactory::CLegFactory()
{
}


CLegFactory::~CLegFactory()
{
}


shared_ptr<IRobotComponent> CLegFactory::create(const std::string &material)
{
	return shared_ptr<IRobotComponent>(new CLeg{ material });
}