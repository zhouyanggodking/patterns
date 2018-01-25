#pragma once
#include "IMessageObserver.h"
class CStudent :
	public IMessageObserver
{
public:
	CStudent();
	virtual ~CStudent();
	virtual void update(const std::string &msg);
};

