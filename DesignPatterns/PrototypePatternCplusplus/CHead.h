#pragma once
#include "stdafx.h"
#include "IRobotComponent.h"
#include "IClonable.h"

using std::string;
using std::ostream;
class CHead :public IRobotComponent, public IClonable
{
public:
	CHead(const string &);
	~CHead();
	virtual void display()const;
	const string& getHeadType()const;
	void setHeadType(const string &);
	virtual std::shared_ptr<IClonable> clone()const;
	friend ostream& operator<<(ostream &, const CHead&);
private:
	string type;
};

