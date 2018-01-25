// BridgePatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CPlatformImplementor.h"
#include "CUI.h"
#include "CLinux.h"
#include "CUIButton.h"
#include "CWindows.h"

#include <memory>


int _tmain(int argc, _TCHAR* argv[])
{
	std::shared_ptr<CWindows> pImpl{ new CWindows };

	CUIButton button{ pImpl };

	button.show();

	std::cout << "/////////////////////////" << std::endl;

	CUIButton linux_button{ std::shared_ptr < CLinux > {new CLinux} };

	linux_button.show();

	return 0;
}

