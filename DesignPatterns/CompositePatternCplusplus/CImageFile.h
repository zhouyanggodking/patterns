#pragma once
#include "IFileComponent.h"
class CImageFile :
	public IFileComponent
{
public:
	CImageFile(const std::string& file_name);
	virtual ~CImageFile();
	virtual void move();
private:
	std::string name;
};

