#pragma once
#include "IRobotComponent.h"
#include <memory>
#include <string>
#include <cctype>
#include <algorithm>
#include <iostream>

template<typename RobotComponent>
class CVirtualProxy
	: IRobotComponent
{
public:
	CVirtualProxy(const std::string &compMaterial)
		:material(compMaterial), comp(nullptr)
	{

	}

	virtual void display()const
	{
		if (comp == nullptr)//use double lock check to avoid thread safe problem
		{
			std::cout << "Initializing a new component..." << std::endl;
			comp = std::make_shared<RobotComponent>(material);
		}
		comp->display();
	}

private:
	std::string material;
	mutable std::shared_ptr<RobotComponent> comp;
};