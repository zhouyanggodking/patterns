#include "stdafx.h"
#include "CHead.h"

using std::string;
using std::ostream;
using std::endl;
using std::cout;
CHead::CHead(const string &headType)
	: type(headType)
{
}


CHead::~CHead()
{
}

void CHead::display()const
{
	cout << type << endl;
}

const string& CHead::getHeadType()const
{
	return type;
}

void CHead::setHeadType(const string &headType)
{
	type = headType;
}

std::shared_ptr<IClonable> CHead::clone()const
{
	//deep copy or shallow copy you should care
	return std::shared_ptr<IClonable>(new CHead{ *this });
}

ostream& operator<<(ostream &os, const CHead&head)
{
	os <<"Head type: "<< head.type;
	return os;
}