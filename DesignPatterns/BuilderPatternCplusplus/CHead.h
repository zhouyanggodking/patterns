#pragma once
#include "stdafx.h"
#include "IRobotComponent.h"

using std::string;
using std::ostream;
class CHead :public IRobotComponent
{
public:
	CHead(const string &);
	~CHead();
	virtual void display()const;
	const string& getHeadType()const;
	void setHeadType(const string &);
	friend ostream& operator<<(ostream &, const CHead&);
private:
	string type;
};

