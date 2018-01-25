#pragma once

#include "stdafx.h"
#include "IRobotComponent.h"

using std::string;
using std::ostream;

class CArm :public IRobotComponent
{
public:
	CArm(const string &);
	~CArm();
	virtual void display()const;
	const string& getArmType()const;
	void setArmType(const string&);
	friend ostream& operator<<(ostream &os, const CArm&);
private:
	string type;
};

