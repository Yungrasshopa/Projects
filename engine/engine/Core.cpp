#include "Core.h"
#include <iterator>
#include <algorithm>

void Core::Initialize(void)
{
	std::cout << "Core: Initialzie" << std::endl;

	std::list<System*>::iterator systemIT = systems.begin();
	for (; systemIT != systems.end(); ++systemIT)
	{
		(*systemIT)->Initialize();
	}

}

void Core::AddSystem(System * system)
{
	systems.push_back(system);
}

void Core::Run(float dt)
{
	std::list<System*>::iterator systemIT = systems.begin();
	for (; systemIT != systems.end(); ++systemIT)
	{
		// TODO: Calculate dt
		(*systemIT)->Update(dt);
	}
}
