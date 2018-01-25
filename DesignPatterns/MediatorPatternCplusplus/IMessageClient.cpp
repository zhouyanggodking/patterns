#include "stdafx.h"
#include "IMessageClient.h"


IMessageClient::IMessageClient(std::shared_ptr<IMessageMediator> msgBus, const std::string&clientId)
	:mediator(msgBus), id(clientId)
{
}


IMessageClient::~IMessageClient()
{
}
