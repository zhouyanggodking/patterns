#pragma once
class IRobotComponent
{
public:
	IRobotComponent();
	virtual ~IRobotComponent() = 0;
	virtual void display()const = 0;
};

