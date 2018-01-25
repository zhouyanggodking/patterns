#pragma once
#include "CPlatformImplementor.h"
class CWindows :
	public CPlatformImplementor
{
public:
	CWindows();
	virtual ~CWindows();
	virtual void display()const;
};

