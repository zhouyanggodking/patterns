#include "stdafx.h"
#include "CTorsorFactory.h"
#include "CTorso.h"


CTorsorFactory::CTorsorFactory()
{
}


CTorsorFactory::~CTorsorFactory()
{
}


shared_ptr<IRobotComponent> CTorsorFactory::create(const std::string &material)
{
	return shared_ptr<IRobotComponent>(new CTorso{ material });
}