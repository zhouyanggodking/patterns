#include "stdafx.h"
#include "CWeaponDecorator.h"


CWeaponDecorator::CWeaponDecorator(std::shared_ptr<IRobotComponent> r_component)
	:CRobotComponentDecorator(r_component)
{
}


CWeaponDecorator::~CWeaponDecorator()
{
}


void CWeaponDecorator::display()const
{
	//CRobotComponentDecorator::display();
	component->display();
	std::cout << "Robot component Weapon decorated..." << std::endl;
}