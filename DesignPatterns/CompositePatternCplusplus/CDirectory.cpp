#include "stdafx.h"
#include "CDirectory.h"
#include <algorithm>

CDirectory::CDirectory(const std::string &directory_name,
	std::vector< std::shared_ptr<IFileComponent> > components)
	:name(directory_name), fileComponents(components)
{
}


CDirectory::~CDirectory()
{
}


void CDirectory::move()
{
	std::cout << "Directory: " << name << " moves..." << std::endl;

	std::for_each(std::begin(fileComponents), std::end(fileComponents),
		[](std::shared_ptr<IFileComponent> c){
		c->move();
	});
}