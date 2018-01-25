// StrategyPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "CContext.h"
#include "CHeapSortStrategy.h"
#include "CMergeSortStrategy.h"

#include <memory>

int _tmain(int argc, _TCHAR* argv[])
{

	auto heapSortStrategy = std::make_shared<CHeapSortStrategy>();

	auto mergeSortStrategy = std::make_shared<CMergeSortStrategy>();

	auto context = std::make_shared<CContext>(heapSortStrategy);

	context->sort();

	context = std::make_shared<CContext>(mergeSortStrategy);

	context->sort();

	return 0;
}

