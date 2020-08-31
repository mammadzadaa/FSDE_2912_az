#include<iostream>

using std::cout;
using std::endl;


struct Entity
{
	int a;
	int b;
};

class Fraction
{
private:
	int num;
	int denum;
public:
	Fraction(int n, int d) : num(n), denum(d) {}
	void showFraction()
	{
		cout << num << " / " << denum << endl;
	}
	virtual ~Fraction() {}
};

class HackFraction
{
public:
	int num;
	int denum;
};

class Base{
public:
	virtual ~Base() {}
};
class Derived : public Base {
public:	void foo() { cout << "hey\n"; }
};

int main()
{
	Derived d;
	Base b;
	
	Base* bp = new Derived();
	//Derived* dp = bp;
	
	//Derived* dp = dynamic_cast<Derived*>(bp);

	Fraction* f = new Fraction(1,3);
	Derived* dp = dynamic_cast<Derived*>(f);


	if(dp)
	dp->foo();

	//reinterpret_cast  // nadir istifade

	/*float f = 12.45;
	float* ptr = &f;

	int* t = reinterpret_cast<int*>(ptr);*/

	//const cast // nadir istifade
	/*int i = 45;
	const int* ptr = &i;
	(*ptr)+= 10;

	int* pt = ptr;

	int* num = const_cast<int*>(ptr);
	(*num) += 10;*/

	//static cast   // genish istifade
	//HackFraction f;

	//double d = 34.12;
	//int r = static_cast<int>(d);

	//int* ptr = static_cast<int*>(&f);



	//int* p = (int*)&f;

	/*
	cout << typeid(45 + 32.1).name() << endl;

	cout << typeid(f).name() << endl;*/

	

	/*float num = 34.45;
	int n = num;
	cout << n << endl;
	n = *(int*)&num;
	cout << n << endl;*/


	//Fraction f(1, 3);
	//f.showFraction();
	//HackFraction* h = (HackFraction*)&f;
	//h->num = 2;
	//f.showFraction();

	/*Entity x{ 10,45 };
	int* ptr = (int*)&x;

	cout << ptr[0] << " " << ptr[1] << endl;*/

	/*float a = 3.25;
	float f = 2.8;

	int h = a + f;
	cout << h << endl;
	 h = (int)a + f;
	cout << h << endl;*/

	/*int b = a;
	unsigned int c = 69321;
	unsigned short d = c;*/

	//cout << d << endl;


	return 0;
}