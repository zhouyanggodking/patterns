#pragma once
#include <memory>
#include <string>
class IMessageClient;
class IMessageMediator
{
public:
	IMessageMediator();
	virtual ~IMessageMediator();
	virtual void dispatch(std::shared_ptr<IMessageClient> reciever, const std::string &msg)const = 0;
	virtual void addClient(std::shared_ptr<IMessageClient> client)=0;
	virtual void removeClient(std::shared_ptr<IMessageClient> client)=0;
};

