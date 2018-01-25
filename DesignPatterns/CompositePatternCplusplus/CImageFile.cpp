#include "stdafx.h"
#include "CImageFile.h"


CImageFile::CImageFile(const std::string& file_name)
	:name(file_name)
{
}


CImageFile::~CImageFile()
{
}

void CImageFile::move()
{
	std::cout << "Image file: " << name << " moves..." << std::endl;
}
