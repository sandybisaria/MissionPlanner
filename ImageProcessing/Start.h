#pragma once

#ifdef START_EXPORTS
#define START_API __declspec(dllexport) 
#else
#define START_API __declspec(dllimport) 
#endif

#include <thread>
#include <iostream>
#include <chrono>

using namespace std;

class Start
{
private:
	static void outputToStream(Start*);
	static void finishExecution(Start*);
	thread mainThread;
	thread stopThread;
public:
	bool keepGoing;
	Start(void);
};