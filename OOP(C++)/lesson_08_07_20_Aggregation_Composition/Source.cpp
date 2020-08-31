#include<array>
#include<list>
#include <iostream>


//#include<queue>
//
//class MyClass
//{
//public:
//
//	enum Priority
//	{
//		High = 1, Medium, Low
//	};
//	struct MyStruct
//	{
//		Priority priority;
//
//	};
//	void push(Priority priority)
//	{
//		MyStruct s;
//		s.priority = priority;
//	}
//
//private:
//
//};

class Sample
{
private:
	class Private
	{

	};

public:

	class Public
	{
	public:
		int num;
	};

};

class Student
{
public:
	char* name;
	char* surname;
	Student(const char* name, const char* surname)
	{
		this->name = _strdup(name);
		this->surname = _strdup(surname);
	}
	~Student()
	{
		delete[] name;
		delete[] surname;
	}
};

class Classroom
{
private:
	std::list<Student*> students;
public:
	Classroom() {}
	~Classroom()
	{
		for (auto s : students)
		{
			delete s;
		}
	}
	void Add(Student* studetn)
	{
		students.push_back(studetn);
	}
	Student* GetFirst()
	{
		return *(students.begin());
	}
};


int main()
{
	Student* s = new Student("Aftandil", "Mammadov");
	Student* ss = new Student("Israfil", "Ibishov");
	Classroom* classroom = new Classroom;
	classroom->Add(s);
	classroom->Add(ss);

	std::cout << classroom->GetFirst()->name << "  " << classroom->GetFirst()->surname << "\n";

	delete classroom;

	std::cout << s->name << "\n";

	//Sample::Public p;
	//p.num;

	//std::array<int,10> arr;

	//arr.at(10);
	//
	//std::array<int,10>::iterator iter = arr.begin();
	//auto iter1 = arr.begin();

	//iter.operator++;

	//std::list<int> list;

	//std::list<int>::iterator iter2 =  list.begin();
	//iter2.operator++;
	//

	//MyClass c;
	//c.push(MyClass::High);
	//
	//std::queue<int> q;
	
	return 0;
}