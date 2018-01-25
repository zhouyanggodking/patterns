#include "stdafx.h"
#include "CStudent.h"


CStudent::CStudent()
{
}


CStudent::~CStudent()
{
}

void CStudent::update(const std::string &msg)
{
	std::cout << "Student recieved message: " << msg << std::endl;
}
