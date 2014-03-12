// TestDll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "TestDll.h"
#include <stdexcept>

using namespace std;

namespace TestDll
{
	double TestDll::Add(double a, double b)
	{
		return a+b;
	}

	double TestDll::Subtract(double a, double b)
	{
		return a-b;
	}

	double TestDll::Multiply(double a, double b)
	{
		return a*b;
	}

	double TestDll::Divide(double a, double b)
	{
		if(b == 0)
			throw invalid_argument("b cannot be zero");
		return a/b;
	}
}


