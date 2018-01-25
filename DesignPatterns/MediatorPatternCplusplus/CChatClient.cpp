#include "stdafx.h"
#include "CChatClient.h"
#include <iostream>
#include "IMessageMediator.h"


CChatClient::CChatClient(std::shared_ptr<IMessageMediator> msgBus, const std::string&clientId)
	:IMessageClient(msgBus, clientId)
{
	//std::cout << "Client: {" << id << "} constructed..." << std::endl;
	msgBus->addClient(std::make_shared<CChatClient>(*this));
}


CChatClient::~CChatClient()
{
	//std::cout << "Client: {" << id << "} destructed..." << std::endl;
}

void CChatClient::send(std::shared_ptr<IMessageClient> reciver, const std::string&msg)const
{
	std::cout << "Client: {" << id << "} sent message " << msg << std::endl;
	mediator->dispatch(reciver, msg);
}


void CChatClient::notify(const std::string&msg)const
{
	std::cout << "Client: {" << id << "} recieved message " << msg << std::endl;
}
