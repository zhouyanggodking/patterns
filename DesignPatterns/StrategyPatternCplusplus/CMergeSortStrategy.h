#pragma once
#include "ISortAlgorithmStrategy.h"
class CMergeSortStrategy :
	public ISortAlgorithmStrategy
{
public:
	CMergeSortStrategy();
	virtual ~CMergeSortStrategy();
	virtual void sort();
};

