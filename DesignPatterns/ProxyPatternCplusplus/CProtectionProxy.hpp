#pragma once
#include "IRobotComponent.h"
#include <memory>
#include <string>
#include <cctype>
#include <algorithm>
#include <iostream>


class Commander
{
public:
	Commander(const std::string &name, const std::string &psw)
		:username(name), password(psw)
	{
			
	}

	bool authenticate()const
	{
		return (toUpper(username) == "GODKING" && password == "Igtcorp123");
	}
private:
	std::string toUpper(const std::string str) const
	{
		std::string temp(str);
		std::transform(str.begin(), str.end(), temp.begin(), ::toupper);
		return temp;
		
	}
private:
	std::string username;
	std::string password;
};


class CProtectionProxy :
	public IRobotComponent
{
public:
	CProtectionProxy(std::shared_ptr<IRobotComponent> robotComponent,
		std::shared_ptr<Commander> commander)
		: comp(robotComponent), cmder(commander)
	{

	}
	~CProtectionProxy()
	{
	}
	virtual void display()const
	{
		if (!cmder->authenticate())
			std::cout << "Unauthenticated..." << std::endl;
		else
		{
			std::cout << "Authenticated..." << std::endl;
			comp->display();
		}
	}

private:
	std::shared_ptr<IRobotComponent> comp;
	std::shared_ptr<Commander> cmder;
};
