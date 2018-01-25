#pragma once

#include "stdafx.h"
#include "IRobotComponent.h"
#include "IClonable.h"

using std::string;
using std::ostream;

class CArm :public IRobotComponent, public IClonable
{
public:
	CArm(const string &);
	~CArm();
	virtual void display()const;
	const string& getArmType()const;
	void setArmType(const string&);
	virtual std::shared_ptr<IClonable> clone()const;
	friend ostream& operator<<(ostream &os, const CArm&);
private:
	string type;
};

