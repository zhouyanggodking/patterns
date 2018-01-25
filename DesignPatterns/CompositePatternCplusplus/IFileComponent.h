#pragma once
class IFileComponent
{
public:
	IFileComponent();
	virtual ~IFileComponent();
	virtual void move() = 0;
};

