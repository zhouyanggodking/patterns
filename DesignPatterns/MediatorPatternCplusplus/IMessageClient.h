#pragma once
#include <memory>
#include <string>
class IMessageMediator;
class IMessageClient
{
public:
	IMessageClient(std::shared_ptr<IMessageMediator> msgBus, const std::string&clientId);
	virtual ~IMessageClient();
	virtual void send(std::shared_ptr<IMessageClient> reciever, const std::string&)const = 0;
	virtual void notify(const std::string&)const = 0;

protected:
	std::shared_ptr<IMessageMediator> mediator;
	std::string id;
};

