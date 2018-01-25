#pragma once
#include "IRobotComponent.h"
#include <memory>
class CRobotComponentDecorator :
	public IRobotComponent
{
public:
	CRobotComponentDecorator(std::shared_ptr<IRobotComponent> r_component);
	virtual ~CRobotComponentDecorator() = 0;
	virtual void display()const = 0;
protected:
	std::shared_ptr<IRobotComponent> component;
};

