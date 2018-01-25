#include "stdafx.h"
#include "CUIButton.h"
#include "CPlatformImplementor.h"


CUIButton::CUIButton(std::shared_ptr<CPlatformImplementor> implementor)
	: CUI(implementor)
{
}


CUIButton::~CUIButton()
{
}

void CUIButton::show()const
{
	std::cout << "CUIButton shows on screen" << std::endl;
	pImpl->display();
}
