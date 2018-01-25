#pragma once

#include <string>
#include <memory>

class IMessageObserver;
class IMessageSource
{
public:
	IMessageSource();
	virtual ~IMessageSource();
	virtual void addSub(std::shared_ptr<IMessageObserver> observer) = 0;
	virtual void remove(std::shared_ptr<IMessageObserver> observer) = 0;
	virtual void notify(const std::string&) = 0;
};

