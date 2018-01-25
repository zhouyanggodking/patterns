#pragma once
#include "stdafx.h"
#include "IRobotComponent.h"
#include "IClonable.h"
using std::string;
using std::ostream;
class CLeg :public IRobotComponent, public IClonable
{
public:
	CLeg(const string &);
	~CLeg();
	virtual void display()const;
	const string& getLegType()const;
	void setLegType(const string&);
	virtual std::shared_ptr<IClonable> clone()const;
	friend ostream& operator<<(ostream &os, const CLeg&);
private:
	string type;
};

