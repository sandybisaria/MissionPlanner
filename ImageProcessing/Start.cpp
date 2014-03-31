#include "Start.h"

void Start::outputToStream(bool& input)
{
	while (input)
	{
		std::cout << "Testing..." << std::endl;
		std::this_thread::sleep_for(std::chrono::seconds(1));
	}
}

Start::Start(void)
{
	keepGoing = true;
	mainThread = std::thread(&outputToStream);
}

void Start::stop(void)
{
	keepGoing = false;
}