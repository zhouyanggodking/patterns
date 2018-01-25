#pragma once
class ISortAlgorithmStrategy
{
public:
	ISortAlgorithmStrategy();
	virtual ~ISortAlgorithmStrategy();
	virtual void sort() = 0;
};

