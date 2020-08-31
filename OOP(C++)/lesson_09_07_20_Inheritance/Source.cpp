#include <iostream>
using namespace std;

class Animal
{
private:
	int a;
protected:
	int b;
	int get()
	{
		return a;
	}
public:
	Animal(int a) {
		cout << "Animal\n";
	}
	~Animal()
	{
		cout << "~Animal\n";
	}
	int c;
};

class Dog : protected Animal
{
private:
	int aa;
protected:
	int bb;
public:
	Animal::b;
	Dog() : Animal(12)
	{
		cout << "Dog\n";
	}
	~Dog() 
	{
		cout << "~Dog\n";
	}
	int cc;
	void foo() 
	{
		Animal::get();
		Animal::b = 12;
		Animal::c = 13;
	}
};

class Husky : public Dog
{
private:
	Animal::b;
public:
	Husky() : Dog() { cout << "Husky\n"; }
	~Husky() { cout << "~Husky\n"; }
	Dog::bb;
	
};

class Person
{
private:
	char* _name;
	char* _surname;
public:
	Person(const char* name,const char* surname) 
	{
		_name = _strdup(name);
		_surname = _strdup(surname);
	}
};

class Student : public Person
{
private:
	char* _school;
public:
	Student(const char* name, const char* surname, const char* school) : Person(name,surname)
	{
		_school = _strdup(school);
	}
};

class Teacher : public Person
{

};

class Human
{
public:
	int i;
	Human() { cout << "Human\n"; }
};

class Father : virtual public Human
{
protected:
	int a;
public:
	Father() { cout << "Father\n"; }
};
class Programmer: virtual public Human
{
protected:
	int b;
public:
	Programmer() { cout << "Programmer\n"; }
};

class ProgrammerMale : public Father, public Programmer
{
public:
	ProgrammerMale() { cout << "Programmer Male\n"; }
	void foo()
	{
		Human::i = 12;
		Father::a;
		Programmer::b;
	}
};

int main()
{

	Human* g = new Programmer();
	//Programmer* p = new Human();
	//Father* f = new Programmer();

	ProgrammerMale m;
	m.i = 45;

	//Animal a(12);
	//
	//Dog d;
	//d.b;

	//Husky h;
	//h.b;

	//cout << sizeof(Animal) << endl << sizeof(Dog) << endl;
	
	return 0;
}