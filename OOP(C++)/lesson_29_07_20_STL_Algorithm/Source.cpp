#include<iostream>
#include<algorithm>
#include<list>
#include<vector>

using namespace std;

class Functor
{
private:
	int _state;
public:
	Functor(int state) : _state(state) {}
	void operator()(int num) 
	{
		cout << num + _state << "  ";
	}
};

int main()
{
	vector<int> aftandil;
	aftandil.push_back(231);
	aftandil.push_back(11);
	aftandil.push_back(21);
	aftandil.push_back(239);
	aftandil.push_back(199);
	aftandil.push_back(100);

	for_each(aftandil.begin(), aftandil.end(), [](int num) {cout << num << "  "; });
	cout << endl;

	sort(aftandil.begin(), aftandil.end());

	for_each(aftandil.begin(), aftandil.end(),Functor(0));
	cout << endl;

	//[](){}(); //lambda expression
	//
	//int a = 5;
	//cout <<
	//[=] // = sending all by value , & sending all by reference
	//(int num) 
	//	-> bool
	//{
	//	cout << num << " Hello World\n" << a << endl; 
	//	return a < 5;
	//}
	//(12) 
	//<< endl;


	int(*ptr_to_foo)(int, int);
	ptr_to_foo = [](int a, int b) -> int {return a + b;};
	ptr_to_foo(12,13); // bu ve bu [](int a, int b) -> int {return a + b;} (12,13); eyni ish gorur

	return 0;
}