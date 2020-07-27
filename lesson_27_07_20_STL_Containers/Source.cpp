#include <iostream>
using namespace std;

//Sequence Containers
#include<vector> // done
#include<array> // done
#include<list> // done
#include<forward_list> // done //C++11
#include<initializer_list> // done
#include <deque>
//Sequence Containers

//Container Adaptors
#include<queue>
#include<stack>
//Container Adaptors

//Associative Containers
#include<set>
#include<map>
//Associative Containers

//Unordered Associative Containers
#include<unordered_set>
#include<unordered_map>
//Unordered Associative Containers

template<class T>
class my_forward_list
{
public:
	class Iterator
	{

	};
};

int main()
{

	forward_list<int> flist;
	flist.push_front(12);
	flist.push_front(13);
	flist.push_front(14);

	auto iter = flist.begin();

	forward_list<int>::iterator i;

	for (auto i = flist.begin(); i!= flist.end(); i++)
	{
		cout << *i << " ";
	}
	


	/*set<int> set;
	int arr[]{ 2,3,6,8,1,5,0,9,4,7 };
	for (auto i : arr)
	{
		set.insert(i);
	}
	int j = 0;
	for (auto i : set)
	{
		arr[j++] = i;
	}
	for (auto i : arr)
	{
		cout << i << " ";
	}
	cout << endl;*/
	//multiset<int> mset;
	
	/*map<int, char> map;
	map.insert(make_pair<int,char>(2,'A'));
	map.insert(make_pair<int, char>(1, 'C'));
	map.insert(make_pair<int, char>(5, 'F'));
	map.insert(make_pair<int, char>(3, 'J'));
	map.insert(make_pair<int, char>(6, 'D'));
	map.insert(make_pair<int, char>(4, 'B'));
	for (auto i : map)
	{
		cout << i.second << " ";
	}
	cout << endl;
	multimap<int, char> mmap;*/

	//queue<int> queue;
	//queue.push(12);
	//queue.push(13);
	//queue.push(14);
	//queue.back(); 
	//cout << queue.front(); //peek
	//queue.pop();
	//cout << queue.front();
	//
	//stack<int> stack;
	//stack.push(12);
	//stack.push(11);
	//stack.push(10);
	//stack.top(); // peek
	//stack.pop();
	//
	//priority_queue<int> pq;
	//deque<int> deque;
	
	return 0;
}