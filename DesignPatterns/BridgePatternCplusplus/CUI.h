#pragma once
#include <memory>
class CPlatformImplementor;
class CUI
{
public:
	CUI(std::shared_ptr<CPlatformImplementor> implementor);
	virtual ~CUI();
	virtual void show()const = 0;
protected:
	std::shared_ptr<CPlatformImplementor> pImpl; //effective c++, the pImpl idiom
};

