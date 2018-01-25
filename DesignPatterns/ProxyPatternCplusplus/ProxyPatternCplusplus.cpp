// ProxyPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CArm.h"
#include "CProtectionProxy.hpp"
#include <memory>
#include <string>
#include "CVirtualProxy.hpp"

int _tmain(int argc, _TCHAR* argv[])
{
	std::string name("godking");
	std::string password("Igtcorp123");
	std::shared_ptr<Commander> cmder{ new Commander{ name, password } };

	std::string material("IRON");
	std::shared_ptr<CArm> arm(new CArm(material));

	//auto arm2 = std::make_shared<CArm>("GODLEN");

	std::shared_ptr< CProtectionProxy > armProxy{ new CProtectionProxy{ arm, cmder } };

	//auto proxy = new CProtectionProxy<CArm>(arm, cmder);

	armProxy->display();
	

	std::cout << "////////////////" << std::endl;


	auto virtualProxy = std::make_shared< CVirtualProxy<CArm> >(material);

	virtualProxy->display();

	return 0;
}

