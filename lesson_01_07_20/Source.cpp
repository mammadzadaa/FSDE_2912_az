#include <iostream>

#include <array>
#include <stack>
#include <queue>

using std::array;
using std::stack;
using std::queue;
using std::cout;
using std::endl;

template<typename T, size_t size>
class Array
{
public:
	T* data;
	size_t _size;

	Array()
	{
		_size = size;
		data = new T[_size]{};
	}
};

template <typename T>
class Stack
{
private:
	T* data;
	size_t size;

public:
	Stack() {}
	Stack(const Stack& other) {}
	Stack(Stack&& other) {}

	void Push(T val) {}
	T Top() const {}
	void Pop() {}
	size_t Size() const {}
};

int main()
{
	queue<int> q;
						//	  yazilma	silinme 	
	q.push(13);			//		 1		   1
	q.push(14);			//		 2		   2
	q.push(15);			//		 3		   3
	q.push(16);			//	     4		   4

	cout << q.back() << endl;
	cout << q.front() << endl;
	q.pop();
	cout << q.front() << endl;


	//Stack<int> a;

	//stack<int> st;
	//             //	  yazilma	silinme  			
	//st.push(13); //		 1		   3
	//st.push(15); //		 2		   2
	//st.push(17); //		 3		   1

	//cout << st.top() << endl;
	//st.pop();
	//cout << st.top() << endl;
	//cout << st.size << endl;
	//st.empty();
	
	
	//array<int,10> arr;
	//int* arr2 = new int[10];
	//arr.max_size();
	

	//auto aftandil = arr.begin();
	//int a = *aftandil;
	//Array<int, 10> arr1;
	//for (auto val : arr)
	//{	}


	return 0;
}