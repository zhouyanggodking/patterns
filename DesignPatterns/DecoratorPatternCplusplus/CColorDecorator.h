#pragma once
#include "CRobotComponentDecorator.h"
class CColorDecorator :
	public CRobotComponentDecorator
{
public:
	CColorDecorator(std::shared_ptr<IRobotComponent> r_component);
	virtual ~CColorDecorator();
	virtual void display()const;
private:
	void display_color()const;
};

