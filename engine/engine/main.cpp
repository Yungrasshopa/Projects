#include <iostream>
#include "Core.h"
#include "System.h"
#include "Graphics.h"


int main(void)
{
	std::cout << "hello" << std::endl;

	Core* core = new Core();

	System* graphics = (System*)(new Graphics());
	core->AddSystem(graphics);

	core->Initialize();

	core->Run(0.0f);

	delete core;

	return 0;
}