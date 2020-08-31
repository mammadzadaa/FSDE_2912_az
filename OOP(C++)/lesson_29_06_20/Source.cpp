#include <iostream>

class Aftandil
{
private:
	int _num;
public:
	Aftandil(int a) : _num(a)
	{

	};
	Aftandil() = default;

	static void foo() {};
	void foo1();
	int getNum() 
	{
		return _num;
	}
};



void Aftandil::foo1()
{
};

class Math
{
public:
	Math() = delete;
	static const double Pi;
	static int addNum(int a, int b)
	{
		return a + b;
	}
	static double getCirleSqr(double radius)
	{
		return Pi * radius * radius;
	}
};

const double Math::Pi = 3.14;

class Number
{
private:
	int _num;
public:
	Number() {}
	explicit Number(int num) : _num(num) {}

	Number(const Number& other)
	{

	}

	void operator=(int n) // setter 
	{
		_num = n;
	}
	Number operator=(const Number &other) 
	{
		this->_num = other._num;
		return *this;
	}
	int getNumber(/*const Number this*/) const
	{
		return _num;
	}
};

void foo(Number num)
{

}

class Student
{
private:
	char* name;
public:
	Student(const char* name)
	{
		this->name = _strdup(name);
	}
	Student(const Student& other)
	{
		this->name = _strdup(other.name);
	}
	const char* getName()
	{
		return name;
	}
};



int main()
{
	Student s("Aftandil");
	std::cout << s.getName() << std::endl;


	//foo(12); // implicit call of constructor Number(12) 
	//foo(Number(13));

	//int a = 45;
	//int* ptr = &a;
	//++*(ptr);
	//ptr++;

	//const int* ptr1 = &a; // pointer to constant
	//*(ptr1) = 34;
	//ptr1++;

	//int* const ptr2 = &a;
	//*(ptr2) = 34;
	//ptr2++;

	//const int* const ptr3 = &a;
	//*(ptr3) = 34;
	//ptr3++;

	Number num;
	Number num1;
	Number num2;
	num = 13;
	num2 = num1 = num;
	num2.getNumber();

	std::cout << num.getNumber() << "\n";

	const Number num3(13);
	//num3 = 34;
	num3.getNumber();

	int numr = Math::addNum(12, 14);


	Aftandil::foo();
	//Aftandil::foo1();
	Aftandil f;
	f.foo1();
	f.getNum();
	return 0;
}