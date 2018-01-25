#include "stdafx.h"
#include "CContext.h"
#include "ISortAlgorithmStrategy.h"

CContext::CContext(std::shared_ptr<ISortAlgorithmStrategy> algorithm)
	:alg(algorithm)
{
}


CContext::~CContext()
{
}


void CContext::sort()
{
	alg->sort();
}