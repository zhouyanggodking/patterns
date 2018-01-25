#include "stdafx.h"
#include "CRobot.h"


CRobot::CRobot()
	: arm(NULL), head(NULL), leg(NULL), torso(NULL)
{
}

CRobot::CRobot(const shared_ptr<CArm> &robotArm,
	const shared_ptr<CHead> &robotHead,
	const shared_ptr<CLeg> &robotLeg,
	const shared_ptr<CTorso> &robotTorso)
	: arm(robotArm),
	head(robotHead),
	leg(robotLeg),
	torso(robotTorso)
{

}

//deep copy
CRobot::CRobot(const CRobot &rhs)
	: arm(shared_ptr<CArm>(new CArm((*rhs.arm).getArmType()))),
	head(shared_ptr<CHead>(new CHead((*(rhs.head)).getHeadType()))),
	leg(shared_ptr<CLeg>(new CLeg((*(rhs.leg)).getLegType()))),
	torso(shared_ptr<CTorso>(new CTorso((*(rhs.torso)).getTorsoType())))
{

}

CRobot& CRobot::operator=(const CRobot& rhs)
{
	if (this == &rhs)
		return *this;
	arm = shared_ptr<CArm>(new CArm((*rhs.arm).getArmType()));
	head=shared_ptr<CHead>(new CHead((*(rhs.head)).getHeadType()));
	leg = shared_ptr<CLeg>(new CLeg((*(rhs.leg)).getLegType()));
	torso = shared_ptr<CTorso>(new CTorso((*(rhs.torso)).getTorsoType()));
	return *this;
}

CRobot::~CRobot()
{
}

shared_ptr<CArm> CRobot::getArm()const
{
	return arm;
}
void CRobot::setArm(CArm *arm)
{	
	this->arm = shared_ptr<CArm>(arm);
}
shared_ptr<CHead> CRobot::getHead()const
{
	return head;
}
void CRobot::setHead(CHead*head)
{
	this->head = shared_ptr<CHead>(head);
}
shared_ptr<CLeg> CRobot::getLeg()const
{
	return leg;
}
void CRobot::setLeg(CLeg*leg)
{
	this->leg = shared_ptr<CLeg>(leg);
}
shared_ptr<CTorso> CRobot::getTorso()const
{
	return torso;
}
void CRobot::setTorso(CTorso* torso)
{
	this->torso = shared_ptr<CTorso>(torso);
}

ostream& operator<<(ostream&os, const CRobot&robot)
{
	os << *robot.arm << endl;
	os << *robot.head << endl;
	os << *robot.leg << endl;
	os << *robot.torso;
	return os;
}
