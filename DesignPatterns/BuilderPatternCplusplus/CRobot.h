#pragma once

#include <memory>
#include "CArm.h"
#include "CHead.h"
#include "CLeg.h"
#include "CTorso.h"
#include <iostream>

using std::shared_ptr;
using std::cout;
using std::endl;
using std::ostream;

class CRobot
{
public:
	CRobot();
	CRobot(const shared_ptr<CArm> &robotArm,
		const shared_ptr<CHead> &robotHead,
		const shared_ptr<CLeg> &robotLeg,
		const shared_ptr<CTorso> &robotTorso);	
	CRobot(const CRobot&);
	CRobot& operator= (const CRobot&);
	~CRobot();
	shared_ptr<CArm> getArm()const;
	void setArm(CArm*);
	shared_ptr<CHead> getHead()const;
	void setHead(CHead*);
	shared_ptr<CLeg> getLeg()const;
	void setLeg(CLeg*);
	shared_ptr<CTorso> getTorso()const;
	void setTorso(CTorso*);
	friend ostream& operator<<(ostream&, const CRobot&);
private:
	shared_ptr<CArm> arm;
	shared_ptr<CHead> head;
	shared_ptr<CLeg> leg;
	shared_ptr<CTorso> torso;
};

