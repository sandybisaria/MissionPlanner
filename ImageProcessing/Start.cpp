#include "Start.h"

void Start::outputToStream(Start* obj)
{
	while (obj->keepGoing)
	{
		cout << "Testing..." << endl;
		this_thread::sleep_for(chrono::seconds(1));
	}
	return;
}

void Start::finishExecution(Start* obj)
{
	this_thread::sleep_for(chrono::seconds(6));
	obj->keepGoing = false;
}

Start::Start(void)
{
	keepGoing = true;
	mainThread = thread(outputToStream, this);
	stopThread = thread(finishExecution, this);
	mainThread.join();
	stopThread.join();
}