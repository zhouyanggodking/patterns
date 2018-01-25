#include "stdafx.h"
#include "CTorso.h"

using std::string;
using std::ostream;
using std::endl;
using std::cout;

CTorso::CTorso(const string &torsoType)
	: type(torsoType)
{
}


CTorso::~CTorso()
{
}


void CTorso::display()const
{
	cout << type << endl;
}

const string& CTorso::getTorsoType()const
{
	return type;
}

void CTorso::setTorsoType(const string &torsoType)
{
	type = torsoType;
}

ostream& operator<<(ostream &os, const CTorso&torso)
{
	os << "Torso type: " << torso.type;
	return os;
}