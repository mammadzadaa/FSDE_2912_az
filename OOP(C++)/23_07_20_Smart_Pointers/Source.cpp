#include <map>
#include <string>
#include <iostream>
#include <memory>

using std::map;
using std::string;
using std::cout;
using std::endl;

class Student
{
public:
	string name;
	Student() 
	{
		cout << "Constructed\n";
	};
	Student(string str)
	{
		name = str;
		cout << "Constructed\n";
	}
	~Student()
	{
		cout << "Destructed\n";
	}
};

template <typename T, typename ...TArgs >
class my_unique_ptr
{
private:
	T* _ptr;
public:
	my_unique_ptr(T* ptr)
	{
		_ptr = ptr;
	}
	my_unique_ptr()
	{
		_ptr = new T();
	}

	//my_unique_ptr(const my_unique_ptr& other) = delete;
	//my_unique_ptr(my_unique_ptr&& other) = delete;
	//my_unique_ptr& operator=(const my_unique_ptr& other) = delete;  // copy assigment
	//my_unique_ptr& operator=(my_unique_ptr&& other) = delete; // move assigment
	T operator*()
	{
		return *_ptr;
	}
	T* operator->()
	{
		return _ptr;
	}
	~my_unique_ptr()
	{
		delete _ptr;
	}
};

template <typename T, typename ...TArgs >
my_unique_ptr<T> make_my_unique(TArgs...args)
{
	return my_unique_ptr<T>(new T(args...));
}

void foo(std::unique_ptr<Student> smart_ptr)
{

}
void foo1(my_unique_ptr<Student> smart) {}
void foo2(std::shared_ptr<Student> shared) {}

	

template<typename T>
class SmartPrt
{
private:
	T* m_ptr = nullptr;
public:
	SmartPrt() {}
	SmartPrt(T* pointer) : m_ptr(pointer) {}
	~SmartPrt()
	{
		delete m_ptr;
	}
	T* operator=(T* ptr)
	{
		delete m_ptr;
		m_ptr = ptr;
		return ptr;
	}
	T* operator->()
	{
		return m_ptr;
	}
	T& operator*()
	{
		return *m_ptr;
	}
};

template<typename T, typename ...TArgs>
SmartPrt<T> unique_my(TArgs...args)
{
	return SmartPrt<T>(new T(args...));
}


int main()
{
	SmartPrt<Student> s = unique_my<Student>("Name");
	cout << s->name;


	/*std::shared_ptr<Student> ptr = std::make_shared<Student>();

	std::shared_ptr<Student> ptr1 = ptr;

	foo2(ptr1);*/

	/*string str;
	
	std::unique_ptr<Student> s = std::make_unique<Student>(str);
	
	my_unique_ptr<Student> pt = make_my_unique<Student>(str);*/



	//{
	//	my_unique_ptr<Student> my_s_ptr;
	//	// my_unique_ptr<Student> m = my_s_ptr;
	//	// foo1(my_s_ptr);
	//	my_s_ptr->name = "Aftandil";
	//	cout << my_s_ptr->name;
	//}

	//{
	//	std::unique_ptr<Student> smart_ptr;
	//	smart_ptr = std::make_unique<Student>("Aftandil");
	//	cout << smart_ptr->name << endl;
	//	// std::unique_ptr<Student> smart_ptr_2 = smart_ptr;   //icaze vermir
	//	//foo(smart_ptr);  //icaze vermir
	//}

	/*map<int, string> data;

	data.insert(std::pair<int,string>(1,"Dolma"));
	data.insert(std::pair<int, string>(2, "Bozbash"));
	data.insert(std::pair<int, string>(3, "Sup"));

	cout << data.at(2) << endl;*/

	return 0;
}
