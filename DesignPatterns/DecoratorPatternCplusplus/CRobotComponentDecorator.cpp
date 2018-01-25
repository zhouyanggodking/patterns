#include "stdafx.h"
#include "CRobotComponentDecorator.h"


CRobotComponentDecorator::CRobotComponentDecorator(std::shared_ptr<IRobotComponent> r_component)
	:component(r_component)
{
}


CRobotComponentDecorator::~CRobotComponentDecorator()
{
}

void CRobotComponentDecorator::display()const
{
	if (component != nullptr)
	{
		component->display();
	}
}
