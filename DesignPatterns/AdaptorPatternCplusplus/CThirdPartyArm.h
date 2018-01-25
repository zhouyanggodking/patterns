#pragma once
#include <string>
class CThirdPartyArm
{
public:
	CThirdPartyArm(const std::string& material);
	~CThirdPartyArm();
	void print()const;
private:
	std::string type;
};

