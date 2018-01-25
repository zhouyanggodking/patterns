#include "stdafx.h"
#include "CChatMessageBus.h"
#include <iostream>
#include "IMessageClient.h"
#include <algorithm>


CChatMessageBus::CChatMessageBus()
	:clients()
{
	//std::cout << "Message bus constructed..." << std::endl;
}


CChatMessageBus::~CChatMessageBus()
{
	//std::cout << "Message bus destructed..." << std::endl;
}


void CChatMessageBus::dispatch(std::shared_ptr<IMessageClient> reciever,const std::string &msg)const
{
	if (reciever == nullptr)	
		sendToAll(msg);
	else		
		reciever->notify(msg);
}

void CChatMessageBus::addClient(std::shared_ptr<IMessageClient> client)
{
	clients.push_back(client);
}


void CChatMessageBus::removeClient(std::shared_ptr<IMessageClient> client)
{
	//clients.remove(client);
}

void CChatMessageBus::sendToAll(const std::string& msg)const
{
	std::for_each(std::begin(clients), std::end(clients), [&](std::shared_ptr<IMessageClient> client)
	{	client->notify(msg); });
}

