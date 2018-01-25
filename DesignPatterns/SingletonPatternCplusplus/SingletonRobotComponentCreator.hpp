#pragma once
#include <string>
#include <memory>
#include "IRobotComponent.h"
#include "stdafx.h"

template <typename RobotComponent>
class SingletonRobotComponentCreator
{
public:
	static std::shared_ptr<SingletonRobotComponentCreator> getInstance()
	{
		if (!pInstance)
			pInstance = std::shared_ptr<SingletonRobotComponentCreator>{ new SingletonRobotComponentCreator<RobotComponent> };
		return pInstance;
	}

	std::shared_ptr<RobotComponent> create(const std::string &material);
	~SingletonRobotComponentCreator();
	

private:
	SingletonRobotComponentCreator();
	
	//not implemented for forbidden
	SingletonRobotComponentCreator(const SingletonRobotComponentCreator&);
	SingletonRobotComponentCreator& operator= (const SingletonRobotComponentCreator &);
private:
	static std::shared_ptr<SingletonRobotComponentCreator> pInstance;
};

template<typename RobotComponent>
std::shared_ptr< SingletonRobotComponentCreator<RobotComponent> > SingletonRobotComponentCreator<RobotComponent>::pInstance = nullptr;

template<typename RobotComponent>
SingletonRobotComponentCreator<RobotComponent>::SingletonRobotComponentCreator()
{
	std::cout << typeid(RobotComponent).name() << " type of component creator constructed" << std::endl;
}

template<typename RobotComponent>
SingletonRobotComponentCreator<RobotComponent>::~SingletonRobotComponentCreator()
{
	std::cout << typeid(RobotComponent).name() << " type of component creator destructed" << std::endl;
}

template<typename RobotComponent>
std::shared_ptr<RobotComponent> SingletonRobotComponentCreator<RobotComponent>::create(const std::string &material)
{
	return std::shared_ptr<RobotComponent>(new RobotComponent{ material });
}


//how about just implementing a template method

template <typename RobotComponent>
std::shared_ptr<RobotComponent> create(const std::string &material)
{
	return std::shared_ptr<RobotComponent>(new RobotComponent{ material });
}