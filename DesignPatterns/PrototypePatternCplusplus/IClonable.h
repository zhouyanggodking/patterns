#pragma once
#include <memory>
class IClonable
{
public:
	IClonable();
	virtual ~IClonable() = 0;
	virtual std::shared_ptr<IClonable> clone()const = 0 ;
};

