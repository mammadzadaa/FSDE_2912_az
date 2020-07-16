#include <iostream>
#include <assert.h>
#include <array>
using std::cout;
using std::cin;

class DivisionByZeroException : public std::exception
{ 
public:
	DivisionByZeroException() : exception("Division by 0!") {}
	const char* what() const override
	{

	}
};

static class Calculator
{
public:
	static double Add(const double& num1, const double& num2) 
	{
		return num1 + num2;
	}
	static double Sub(const double& num1, const double& num2)
	{
		return num1 - num2;
	}
	//static double Div(const double& num1, const double& num2)
	//{
	//	assert(num2 != 0 && "Division by 0!\n");
	//	return num1 / num2;
	//}
	static double Div(const double& num1, const double& num2)
	{
		if (num2 == 0)
			throw DivisionByZeroException();

		return num1 / num2;
	}
	static double Mul(const double& num1, const double& num2)
	{
		return num1 * num2;
	}
};


class Exception1 : public std::exception
{
};
class Exception2 : public Exception1
{
};
class Exception3 : public Exception2
{
};
void Foo1()
{
	cout << "Foo1 begin\n";
	 throw Exception3();
	cout << "Foo1 end\n";
}
void Foo2()
{
	cout << "Foo2 begin\n";
	try
	{
		Foo1();
	}
	catch (const Exception3&)
	{
		cout << "Catch Exception 3\n";
		throw;
	}
	cout << "Foo2 end\n";
}
void Foo3()
{
	cout << "Foo3 begin\n";
	try
	{
		Foo2();
	}
	catch (const Exception2&)
	{
		cout << "Catch Exception 2\n";
		throw;
	}
	cout << "Foo3 end\n";
}
int main()
{
	std::array<int,5> arr;
	arr[0] = 1;
	arr[1] = 2;
	arr[2] = 3;
	arr[3] = 4;
	arr[4] = 5;

	try
	{
		arr.at(10);
	}
	catch (const std::out_of_range& ex)
	{
		cout << ex.what() << "\n";
	}
	cout << "\n\nFIN\n";


	//try
	//{
	//	Foo3();
	//}
	//catch (const Exception1&)
	//{
	//	cout << "Catch Exception 1\n";
	//}

	/*try
	{
		while (true)
		{
			int* ptr = new int[100000]{};
		}
	}
	catch (const std::bad_alloc& ex)
	{
		cout << ex.what() << "\n";
	}
	cin.get();*/

//	double a, b;
//	cout << "Enter First number: ";
//	cin >> a;
//	cout << "Enter Second number: ";
//	cin >> b;
//	cout << Calculator::Add(a, b) << "\n";
//	cout << Calculator::Sub(a, b) << "\n";
//	cout << Calculator::Mul(a, b) << "\n";
//	/*if(b != 0)
//	cout << Calculator::Div(a, b) << "\n";
//	else
//	{
//		do
//		{
//			cout << "Division by 0!\n Please reenter the Second number: ";
//			cin >> b;
//		} while (b == 0);
//		cout << Calculator::Div(a, b) << "\n";
//	}*/
//	
//	try
//	{
//		cout << Calculator::Div(a, b) << "\n";	
//	}
//	/*catch (const DivisionByZeroException& ex)
//	{
//		std::cerr << ex.what() << "\n";
//	}*/
//	catch (const std::exception& ex)
//	{
//		cout << "General Exception: ";
//		std::cerr << ex.what() << "\n";
//	}
//	catch (...)
//	{
//		cout << "can catch anything!\n";
//	}

	return 0;
}