#include <iostream>
using std::cout;
using std::endl;

template<typename T>
class LinkedList
{
private:
	struct Node
	{
		T data;
		Node* next = nullptr;
		Node* previous = nullptr;
	};
	Node* _begin = nullptr;
	size_t count = 0;  //istifade edin
public:
	void PushFronst(const T& val)
	{
		Node* temp = new Node;
		temp->data = val;

		if (_begin == nullptr)
		{
			_begin = temp;
			temp->next = temp;
			temp->previous = temp;
			return;
		}
		temp->previous = _begin->previous;
		_begin->previous->next = temp;

		_begin->previous = temp;
		temp->next = _begin;

		_begin = temp;
	}

	void PushBack(const T& val)
	{
		Node* temp = new Node;
		temp->data = val;

		if (_begin == nullptr)
		{
			_begin = temp;
			temp->next = temp;
			temp->previous = temp;
			return;
		}
		_begin->previous->next = temp;
		temp->previous = _begin->previous;

		temp->next = _begin;
		_begin->previous = temp;
		
	}
	void PopFront() 
	{
		_begin->previous->next = _begin->next;
		_begin->next->previous = _begin->previous;

		Node* temp = _begin;
		_begin = _begin->next;
		delete temp;
	}
	void PopBack()
	{
		_begin->previous->previous->next = _begin;
		Node* temp = _begin->previous;
		_begin->previous = _begin->previous->previous;
		delete temp;
	}
	T PeekFront()
	{
	//assert
		return _begin->data;
	}
	T PeekBack()
	{
		//assert
		return _begin->previous->data;
	}
};

template<typename T>
class BinaryTree
{
private:
	struct Node
	{
		T data;
		Node* left;
		Node* right;
		Node* parent;
	};
	Node* _root = nullptr;

public:
	void Push(const T& val)
	{
		// your code here
	}
};


int main()
{
	LinkedList<int> list;
	list.PushFronst(12);
	list.PushFronst(11);
	list.PushFronst(10);
	list.PushFronst(9);
	list.PushBack(13);

	list.PushBack(20);

	cout << list.PeekBack() << endl;
	list.PopBack();

	cout << list.PeekFront() << endl;
	list.PopFront();
	cout << list.PeekFront() << endl;
	list.PopFront();
	cout << list.PeekFront() << endl;
	list.PopFront();
	cout << list.PeekFront() << endl;
	list.PopFront();
	cout << list.PeekFront() << endl;
	list.PopFront();

	return 0;
}