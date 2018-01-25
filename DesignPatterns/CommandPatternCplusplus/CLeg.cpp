#include "stdafx.h"
#include "CLeg.h"

using std::string;
using std::ostream;
using std::endl;
using std::cout;

CLeg::CLeg(const string &legType)
	: type(legType)
{
}


CLeg::~CLeg()
{
}


void CLeg::display()const
{
	cout << type << endl;
}

const string& CLeg::getLegType()const
{
	return type;
}

void CLeg::setLegType(const string&legType)
{
	type = legType;
}

ostream& operator<<(ostream &os, const CLeg&leg)
{
	os << "Leg type: " << leg.type;
	return os;
}