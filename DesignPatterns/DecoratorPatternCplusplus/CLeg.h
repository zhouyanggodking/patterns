#pragma once
#include "stdafx.h"
#include "IRobotComponent.h"
using std::string;
using std::ostream;
class CLeg :public IRobotComponent
{
public:
	CLeg(const string &);
	~CLeg();
	virtual void display()const;
	const string& getLegType()const;
	void setLegType(const string&);
	friend ostream& operator<<(ostream &os, const CLeg&);
private:
	string type;
};

