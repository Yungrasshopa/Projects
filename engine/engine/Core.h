#pragma once
#include <list>
#include <iostream>
#include "System.h"

class Core
{
public:

	void Initialize(void);
	
	void AddSystem(System* system);

	void Run(float);

private:

	std::list<System*> systems;

};