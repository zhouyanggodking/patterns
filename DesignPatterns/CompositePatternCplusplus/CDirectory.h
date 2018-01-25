#pragma once
#include "IFileComponent.h"
#include <vector>
#include <memory>
class CDirectory :
	public IFileComponent
{
public:
	CDirectory(const std::string &directory_name, 
		std::vector< std::shared_ptr<IFileComponent> > components);
	virtual ~CDirectory();
	virtual void move();
private:
	std::string name;
	std::vector< std::shared_ptr<IFileComponent> > fileComponents;
};

