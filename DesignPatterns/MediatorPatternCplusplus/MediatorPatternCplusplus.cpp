// MediatorPatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CChatClient.h"
#include "CChatMessageBus.h"
#include <memory>


int _tmain(int argc, _TCHAR* argv[])
{
	auto mediator = std::make_shared<CChatMessageBus>();

	auto client_godking = std::make_shared<CChatClient>(mediator, "godking");

	auto client_ocean = std::make_shared<CChatClient>(mediator, "Ocean");

	auto client_sky = std::make_shared<CChatClient>(mediator, "Sky");

	auto client_shepperd = std::make_shared<CChatClient>(mediator, "Shepperd");


	//godking -> ocean
	//godking -> shepperd

	//sky -> ocean

	//shepperd -> ALL

	//through mediator

	client_godking->send(client_ocean, "Message from godking");

	client_godking->send(client_shepperd, "Message from godking");

	client_sky->send(client_ocean, "Message from sky");

	client_shepperd->send(nullptr, "Message from shepperd");

	return 0;
}

