#pragma once

#ifdef START_EXPORTS
#define START_API __declspec(dllexport) 
#else
#define START_API __declspec(dllimport) 
#endif

#include <thread>
#include <iostream>
#include <chrono>

class Start
{
private:
	static void outputToStream(bool&);
	bool keepGoing;
	std::thread mainThread;
public:
	Start(void);
	void stop(void);
};