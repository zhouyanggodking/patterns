#include "stdafx.h"
#include "CSupperStar.h"
#include <algorithm>
#include "IMessageObserver.h"

CSupperStar::CSupperStar()
{
}


CSupperStar::~CSupperStar()
{
}


void CSupperStar::addSub(std::shared_ptr<IMessageObserver> observer)
{
	observerList.push_back(observer);
}

void CSupperStar::remove(std::shared_ptr<IMessageObserver> observer)
{
	observerList.remove(observer);
}

void CSupperStar::notify(const std::string &msg)
{
	std::for_each(std::begin(observerList), std::end(observerList),
		[&](std::shared_ptr<IMessageObserver>observer){observer->update(msg); });
}