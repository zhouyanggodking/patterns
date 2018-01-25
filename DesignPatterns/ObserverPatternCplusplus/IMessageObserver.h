#pragma once
#include <string>
class IMessageObserver
{
public:
	IMessageObserver();
	virtual ~IMessageObserver();
	virtual void update(const std::string &msg) = 0;
};

