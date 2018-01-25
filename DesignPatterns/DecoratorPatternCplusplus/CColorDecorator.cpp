#include "stdafx.h"
#include "CColorDecorator.h"


CColorDecorator::CColorDecorator(std::shared_ptr<IRobotComponent> r_component)
	:CRobotComponentDecorator(r_component)
{
}


CColorDecorator::~CColorDecorator()
{
}


void CColorDecorator::display()const
{
	//CRobotComponentDecorator::display();
	component->display();
	display_color();
}

void CColorDecorator::display_color()const
{
	std::cout << "Robot component color decorated..." << std::endl;
}