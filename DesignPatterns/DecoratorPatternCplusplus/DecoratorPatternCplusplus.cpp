// DecoratorPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CTorso.h"

#include <memory>
#include "CColorDecorator.h"
#include "CWeaponDecorator.h"


int _tmain(int argc, _TCHAR* argv[])
{
	std::string material{ "IRON" };
	std::shared_ptr<CTorso> torso{ new CTorso{ material } };

	torso->display();

	std::shared_ptr<CColorDecorator> colorDec{ new CColorDecorator{ torso } };

	colorDec->display();

	//cascade
	std::shared_ptr<CWeaponDecorator> weaponDec{ new CWeaponDecorator{ colorDec } };

	weaponDec->display();

	return 0;
}

