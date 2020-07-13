#include<iostream>

using std::cout;
using std::endl;

class A
{
public:
	virtual void foo()
	{
		cout << "A\n";
	}
	virtual void func()
	{
		cout << "FA\n";
	}
};

class B final : public A
{
public:
	void foo() override
	{
		cout << "B\n";
		A::foo();
	}
	void func() override final
	{
		cout << "FB\n";
	}
};

//class C : public B
//{
//public:
//	void func() override 
//	{
//		cout << "CB\n";
//	}
//};

////////////////////////////////////////////////

class DB abstract
{
protected:
	char* _connection_string;
public:
	DB(const char* connection) 
	{
		_connection_string = _strdup(connection);
	}
	~DB()
	{
		delete[] _connection_string;
	}
	virtual void Insert() = 0;
	virtual void Select() = 0;
	virtual void Update() = 0;
	virtual void Delete() = 0;
};

class MSSQL final : public DB
{
public:
	MSSQL(const char* connection) : DB(connection) {}
	void Insert() override 
	{
		cout << "MSSQL Insert on connection: " << _connection_string << endl;
	}
	void Select() override 
	{
		cout << "MSSQL Select on connection: " << _connection_string << endl;
	}
	void Update() override 
	{
		cout << "MSSQL Update on connection: " << _connection_string << endl;
	}
	void Delete() override
	{
		cout << "MSSQL Delete on connection: " << _connection_string << endl;
	}	
};

class SQLLite final : public DB
{
public:
	SQLLite(const char* connection) : DB(connection) {}
	void Insert() override
	{
		cout << "SQLLite Insert on connection: " << _connection_string << endl;
	}
	void Select() override
	{
		cout << "SQLLite Select on connection: " << _connection_string << endl;
	}
	void Update() override
	{
		cout << "SQLLite Update on connection: " << _connection_string << endl;
	}
	void Delete() override
	{
		cout << "SQLLite Delete on connection: " << _connection_string << endl;
	}
};

class MongoDB final : public DB
{
public:
	MongoDB(const char* connection) : DB(connection) {}
	void Insert() override
	{
		cout << "MongoDB Insert on connection: " << _connection_string << endl;
	}
	void Select() override
	{
		cout << "MongoDB Select on connection: " << _connection_string << endl;
	}
	void Update() override
	{
		cout << "MongoDB Update on connection: " << _connection_string << endl;
	}
	void Delete() override
	{
		cout << "MongoDB Delete on connection: " << _connection_string << endl;
	}
};

static class DataAlanizer
{
public:
	static void AnalizeData(DB* database)
	{
		// melumatlar DB e yazilir
		database->Insert();
			// oxunma
		database->Select();
		// data uzerinde ish
		database->Update();
		// data uzerinde hesablama
		database->Delete();		
	}
};

////////////////////////////////////////////////

class Human abstract
{
public:
	virtual void walk() = 0
	{
		cout << "I am walking\n";
	}
};

class Parent abstract
{
public:
	virtual void takeCareOfChild() = 0;
};

class Employee abstract
{
public:
	virtual void work() = 0;
};


class Adult : public Human, public Parent, public Employee
{
public:
	void walk() override
	{
		Human::walk();
	}

	void takeCareOfChild() override
	{
		cout << "Loving kids and buying them a candy!\n";
	}

	void work() override
	{
		cout << "Work hard, die hard!\n";
	}
};


void Work(Employee* employee)
{
	employee->work();
}

void TakeCare(Parent* parent)
{
	parent->takeCareOfChild();
}

void Walk(Human* human)
{
	human->walk();
}

////////////////////////////////////////////////////

class Base
{
private:
	char* str_base;
public:
	Base(const char* str)
	{
		str_base = _strdup(str);
		cout << "Base Constr\n";
	}
	virtual ~Base() = 0
	{
		cout << "Base Destr\n";
		if(str_base != nullptr)
		delete[] str_base;
	}
};

class Derived : public Base
{
private:
	char* str_derived;
public:
	Derived(const char* str,  const char* str_base) : Base(str_base)
	{
		str_derived = _strdup(str);
		cout << "Derived Constr\n";
	}
	~Derived()
	{
		cout << "Derived Destr\n";
		if (str_derived != nullptr)
			delete[] str_derived;
	}
};


int main()
{	
	// Base b("");
	Derived* d = new Derived("Derived", "Base");
	delete d;

	/*Adult* adult = new Adult();

	Work(adult);
	TakeCare(adult);
	Walk(adult);*/


	// DataAlanizer::AnalizeData(new MongoDB(":C/Windows/User/MongoDB/DB"));

	//A* a = new A();
	//A* b = new B();
	//a->func();
	//b->func();

	return 0;
}