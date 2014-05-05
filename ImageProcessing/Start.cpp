#include "Start.h"

void Start::outputToStream(Start* obj)
{
	while (obj->keepGoing)
	{
		obj->count++;
		this_thread::sleep_for(chrono::seconds(1));
	}
	return;
}
/*
void Start::finishExecution(Start* obj)
{
	this_thread::sleep_for(chrono::seconds(6));
	obj->keepGoing = false;
}*/

Start::Start(void)
{
	keepGoing = false;
}

void Start::beginExecution(void)
{
	keepGoing = true;
	mainThread = thread(outputToStream, this);
	mainThread.detach();
}

void Start::endExecution(void)
{
	keepGoing = false;
}

string Start::returnCount(void)
{
	return to_string(count);
}