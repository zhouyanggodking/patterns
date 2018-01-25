#include "stdafx.h"
#include "CDisplayCommand.h"
#include "IRobotComponent.h"


CDisplayCommand::CDisplayCommand(std::shared_ptr<IRobotComponent> robotComponent)
	:comp(robotComponent)
{
}


CDisplayCommand::~CDisplayCommand()
{
}


void CDisplayCommand::execute()const
{
	comp->display();
}
