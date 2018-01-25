#pragma once
#include "IFileComponent.h"
class CTextFile :
	public IFileComponent
{
public:
	CTextFile(const std::string& file_name);
	virtual ~CTextFile();
	virtual void move();
private:
	std::string name;
};

