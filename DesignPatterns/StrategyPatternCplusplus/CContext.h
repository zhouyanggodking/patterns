#pragma once

#include <memory>

class ISortAlgorithmStrategy;

class CContext
{
public:
	CContext(std::shared_ptr<ISortAlgorithmStrategy>);
	~CContext();
	void sort();
private:
	std::shared_ptr<ISortAlgorithmStrategy> alg;
};

