#pragma once
#include "CRobotComponentDecorator.h"
class CWeaponDecorator :
	public CRobotComponentDecorator
{
public:
	CWeaponDecorator(std::shared_ptr<IRobotComponent> r_component);
	virtual ~CWeaponDecorator();
	virtual void display()const;
};

