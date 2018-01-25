#pragma once
#include "ISortAlgorithmStrategy.h"
class CHeapSortStrategy :
	public ISortAlgorithmStrategy
{
public:
	CHeapSortStrategy();
	virtual ~CHeapSortStrategy();
	virtual void sort();
};

