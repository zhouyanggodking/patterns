#include "stdafx.h"
#include "CArm.h"

using std::cout;
using std::endl;
using std::ostream;

CArm::CArm(const string&armType)
	: type(armType)
{
}


CArm::~CArm()
{
}

void CArm::display()const
{
	cout << type << endl;
}

const string& CArm::getArmType()const
{
	return type;
}
void CArm::setArmType(const string& armType)
{
	type = armType;
}

ostream& operator<<(ostream &os, const CArm &arm)
{
	os << "Arm type: " << arm.type;
	return os;
}