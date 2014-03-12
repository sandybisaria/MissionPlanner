#ifdef TESTDLL_EXPORTS
#define TESTDLL_API __declspec(dllexport)
#else
#define TESTDLL_API __declspec(dllimport)
#endif

namespace TestDll
{
	class TestDll
	{
	public:
		static TESTDLL_API double Add(double a, double b);
		static TESTDLL_API double Subtract(double a, double b);
		static TESTDLL_API double Multiply(double a, double b);
		static TESTDLL_API double Divide(double a, double b);
	};

}