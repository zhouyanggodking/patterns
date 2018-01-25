#pragma once
#include "IMessageMediator.h"
#include <memory>
#include <list>


class IMessageClient;
class CChatMessageBus :
	public IMessageMediator
{
public:
	CChatMessageBus();
	virtual ~CChatMessageBus();
	virtual void dispatch(std::shared_ptr<IMessageClient> reciever, const std::string &msg)const;
	virtual void addClient(std::shared_ptr<IMessageClient> client);
	virtual void removeClient(std::shared_ptr<IMessageClient> client);
private:
	void sendToAll(const std::string &msg)const;
private:
	std::list<std::shared_ptr<IMessageClient>> clients;
};

