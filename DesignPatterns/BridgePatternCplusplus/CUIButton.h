#pragma once
#include "CUI.h"
class CPlatformImplementor;
class CUIButton :
	public CUI
{
public:
	CUIButton(std::shared_ptr<CPlatformImplementor> implementor);
	virtual ~CUIButton();
	virtual void show()const;
};

