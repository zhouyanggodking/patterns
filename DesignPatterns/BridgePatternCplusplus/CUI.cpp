#include "stdafx.h"
#include "CUI.h"
#include "CPlatformImplementor.h"


CUI::CUI(std::shared_ptr<CPlatformImplementor> implementor)
	: pImpl(implementor)
{
}


CUI::~CUI()
{
}
