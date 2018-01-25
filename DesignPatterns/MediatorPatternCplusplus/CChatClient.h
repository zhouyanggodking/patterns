#pragma once
#include "IMessageClient.h"
#include <memory>
class CChatClient :
	public IMessageClient
{
public:
	CChatClient(std::shared_ptr<IMessageMediator> msgBus, const std::string&clientId);
	virtual ~CChatClient();
	virtual void send(std::shared_ptr<IMessageClient> reciver ,const std::string&)const;
	virtual void notify(const std::string&)const;
};

