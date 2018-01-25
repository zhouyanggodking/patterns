#include "stdafx.h"
#include "CTextFile.h"


CTextFile::CTextFile(const std::string& file_name)
	:name(file_name)
{
}


CTextFile::~CTextFile()
{
}


void CTextFile::move()
{
	std::cout << "Text file: " << name << " moves..." << std::endl;
}
