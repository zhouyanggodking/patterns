#pragma once
#include "IMessageObserver.h"
class CTeacher :
	public IMessageObserver
{
public:
	CTeacher();
	virtual ~CTeacher();
	virtual void update(const std::string &msg);
};

