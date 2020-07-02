#include<iostream>
#include<assert.h>

using std::cout;
using std::endl;
using std::cin;

template <typename T>
class Array
{
private:
	T* data;
	size_t size;
	mutable T _max;
	mutable bool max_state;
public:
	Array()
	{
		data = nullptr;
		size = 0;
		max_state = false;
	}
	Array(const Array& other)
	{
		this->data = new T[other.size]{};
		this->size = other.size;
		for (size_t i = 0; i < this.size; i++)
		{
			this->data[i] = other.data[i];
		}
	}
	Array(Array&& other)
	{
		delete[] this->data;
		this->data = other.data;
		this->size = other.size;
		other.data = nullptr;
	}
	~Array()
	{
		if (data != nullptr)
			delete[] data;
	}
	void Append(T val)
	{
		T* temp = new T[size + 1]{};
		for (size_t i = 0; i < size; i++)
		{
			temp[i] = data[i];
		}
		temp[size++] = val;
		delete[] data;
		data = temp;
		max_state = false;
	}
	size_t getSize()
	{
		return size;
	}

	T Max() const
	{
		assert(size > 0 && "Size of array is 0");

		if (max_state)
		{
			return _max;
		}
			T max = data[0];
			for (size_t i = 1; i < size; i++)
			{
				if (max < data[i])
				{
					max = data[i];
				}
			}
			max_state = true;
			return _max = max;
	}

	Array<T>& operator=(Array&& other)
	{
		if (this == &other)
			return *this;

		delete[] this->data;

		this->data = other.data;
		this->size = other.size;
		other.data = nullptr;
	}
	T operator[](int index)
	{
		return data[index];
	}
};

class Fraction
{
private:
	int _suret;
	int _mexrec;
public:
	Fraction() = default;
	Fraction(int suret, int mexrec)
	{
		assert(mexrec != 0 && "Mexrec 0-a beraber ola bilmez!");
		_suret = suret;
		_mexrec = mexrec;
	}
	bool operator>(const Fraction& other) const
	{
		return true;
	}
};
template <typename T>
class LinkedList
{
private:
	struct Node
	{
		T data;
		Node* next = nullptr;
	};
	Node* _start = nullptr;
public:
	void Push(const T &val)
	{
		Node* temp = new Node;
		temp->data = val;
		temp->next = _start;
		_start = temp;
	}
	void Pop()
	{
		assert(_start != nullptr && "Linked list boshdur");
		Node* temp = _start;
		_start = _start->next;
		delete[] temp;
	}
	T Peek()
	{
		assert(_start != nullptr && "Linked list boshdur");
		return _start->data;
	}
	void Push_back(const T& val)
	{
		// your code here
	}
	void Pop_back()
	{
		assert(_start != nullptr && "Linked list boshdur");
		if (_start->next == nullptr)
		{
			delete _start;
			_start = nullptr;
			return;
		}
		Node* previous = _start;
		Node* iterator = _start->next;
		while (iterator->next != nullptr)
		{
			previous = iterator;
			iterator = iterator->next;
		}
		previous->next = nullptr;
		delete iterator;
	}
	T Peek_back()
	{
		// your code here
	}

};


int main()
{
	LinkedList<int> list;
	list.Push(13);
	list.Push(14);
	list.Push(15);
	list.Push(16);

	cout << list.Peek() << endl;

	list.Pop();

	cout << list.Peek() << endl;

	/*int sur;
	int mex;
	cin >> sur;
	do
	{
		cin >> mex;

	} while (mex == 0);

	Fraction f(sur,mex);*/
	//Array<int> arr;

	//arr.Max();

	return 0;
}