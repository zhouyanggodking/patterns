#pragma once
class CPlatformImplementor
{
public:
	CPlatformImplementor();
	virtual ~CPlatformImplementor();
	virtual void display()const = 0;
};

