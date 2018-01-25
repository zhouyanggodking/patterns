#include "stdafx.h"
#include "CTeacher.h"


CTeacher::CTeacher()
{
}


CTeacher::~CTeacher()
{
}

void CTeacher::update(const std::string &msg)
{
	std::cout << "Teacher recieved message: " << msg << std::endl;
}
