#pragma once
#include "IMessageSource.h"
#include <memory>
#include <list>

class IMessageObserver;

class CSupperStar :
	public IMessageSource
{
public:
	CSupperStar();
	virtual ~CSupperStar();
	virtual void addSub(std::shared_ptr<IMessageObserver> observer);
	virtual void remove(std::shared_ptr<IMessageObserver> observer);
	virtual void notify(const std::string &msg);
private:
	std::list < std::shared_ptr<IMessageObserver> > observerList;
};

