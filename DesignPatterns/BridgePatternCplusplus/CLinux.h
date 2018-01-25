#pragma once
#include "CPlatformImplementor.h"
class CLinux :
	public CPlatformImplementor
{
public:
	CLinux();
	virtual ~CLinux();
	virtual void display()const;
};

