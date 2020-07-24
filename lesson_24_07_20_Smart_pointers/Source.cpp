#include<iostream>
#include<memory>

//STL
#include<vector>
#include<array>
#include<list>
#include<forward_list>
#include<initializer_list>

using namespace std;

template<class T>
class Shared_ptr 
{
private:
	T* _ptr = nullptr;
	size_t* _count = nullptr;
public:
	Shared_ptr() {
		_count = new size_t(1);
	}
	Shared_ptr(T* ptr) {
		_ptr = ptr;
		_count = new size_t(1);
	}
	Shared_ptr(Shared_ptr& oth) {
		_ptr = oth._ptr;
		(*(oth._count))++;
		_count = oth._count;
	}
	Shared_ptr& operator=(Shared_ptr& oth) {
		if ((*(_count)) != 1) {
			(*(_count))--;
		}
		else {
			delete _ptr;
			delete _count;
		}
		_ptr = oth._ptr;
		(*(oth._count))++;
		_count = oth._count;
		return *this;
	}
	~Shared_ptr() {
		if ((*(_count)) != 1) {
			(*(_count))--;
		}
		else {
			delete _ptr;
			delete _count;
		}
	}
	T* operator->() {
		return _ptr;
	}
	T operator*() {
		return *_ptr;
	}
};
class A {
private:
	int _a;
public:
	A() {
		_a = 90;
		cout << "constructed\n";
	}
	~A() {
		cout << "destructed\n";
	}
	int get() {
		return _a;
	}
};
void foo(Shared_ptr<A>ptr) {
	Shared_ptr<A>ptr1;
	ptr1 = ptr;
	cout << ptr->get() << "\n";
}
void show(weak_ptr<int> ptr)
{
	if(!ptr.expired())
	cout << *(ptr.lock());
}
template<typename T>
bool foo(T)
{
	return true;
}
template<typename T>
bool foo1(T, T) {}

int main() 
{
	//initializer_list<int> il;

	//forward_list<int> fl;


	//list<int> l(10,12);
	//l.empty(); // isempty
	//l.merge(*(new list<int>()));
	//l.remove_if(foo);
	//l.resize(100);
	//l.reverse();
	//l.sort(foo1<int>);
	//l.splice(l.begin(),*(new list<int>()));
	//l.unique();

	//array<int, 10> a; // stack
	//a.fill(17);

	/*
	vector<int> v; // heap
	
	v.size(); 
	v.resize(100,10);
	
	v.capacity();
	v.reserve(100);
	
	v.shrink_to_fit();

	v.clear();

	v.push_back(10);
	v.erase(v.begin());
	v.erase(v.begin()++, v.end()--);
	v.begin();
	v.end();

	v.insert(v.begin() + 5,12);
	v.assign(100,10);

	v.at(1);
	v[1];

	v.back();
	v.data();

	v.emplace(v.begin(),12);

	v.swap(*(new vector<int>()));
	v.pop_back();
	v.push_back(12);
	*/

	//unique_ptr<int> u_ptr = make_unique<int>(100);
	//shared_ptr<int> s_ptr = make_shared<int>(100);
	//// weak_ptr<int> w_ptr = s_ptr;
	//auto_ptr<int> a_ptr(new int);
	//auto_ptr<int> b_ptr = a_ptr;
	//show(s_ptr);

	/*Shared_ptr<A> ptr(new A());
	{
		Shared_ptr<A> ptr1 = ptr;
		foo(ptr1);
	}*/
	return 0;
}