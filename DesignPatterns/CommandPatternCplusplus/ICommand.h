#pragma once
class ICommand
{
public:
	ICommand();
	virtual ~ICommand();
	virtual void execute()const = 0;
};

