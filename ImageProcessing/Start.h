#pragma once

#ifdef START_EXPORTS
#define START_API __declspec(dllexport) 
#else
#define START_API __declspec(dllimport) 
#endif

#include <thread>
#include <iostream>
#include <chrono>
#include <string>

using namespace std;

class Start
{
private:
	int count = 0;
	static void outputToStream(Start*);
	static void finishExecution(Start*);
	thread mainThread;
	thread stopThread;
public:
	bool keepGoing;
	Start(void);
	string returnCount();
};