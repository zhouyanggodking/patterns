#pragma once
#include "stdafx.h"
#include "IRobotComponent.h"

using std::string;
using std::ostream;
class CTorso :public IRobotComponent
{
public:
	CTorso(const string &);
	~CTorso();
	virtual void display()const;
	const string& getTorsoType()const;
	void setTorsoType(const string &torsoType);
	friend ostream& operator<<(ostream &os, const CTorso&);
private:
	string type;
};

