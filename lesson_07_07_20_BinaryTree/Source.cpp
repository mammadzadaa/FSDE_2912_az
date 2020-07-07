#include<iostream>
#include<string>
#include<assert.h>
#include<map>


using std::cout;
using std::endl;
using std::map;
using std::pair;
using std::string;

class Student
{
private:
	char* name;
	char* surname;
public:
	friend std::ostream& operator<<(std::ostream& other, const Student& s);
};

std::ostream& operator<<(std::ostream& other, const Student& s)
{
	cout << "Hi\n";
	return other;
}

template<typename key, typename data>
class BinaryTree
{
private:
	struct Node
	{
		key key;
		data data;
		Node* parent = nullptr;
		Node* right = nullptr;
		Node* left = nullptr;
	};
	Node* _root = nullptr;

	void find_insert(Node* iter, Node* new_node)
	{
		if (new_node->key > iter->key)
		{
			if (iter->right == nullptr)
			{
				iter->right = new_node;
				return;
			}
			else
			{
				find_insert(iter->right, new_node);
			}
		}
		else if(new_node->key < iter->key)
		{
			if (iter->left == nullptr)
			{
				iter->left = new_node;
				return;
			}
			else
			{
				find_insert(iter->left, new_node);
			}
		}
		else
		{
			iter->data = new_node->data;
		}

	}
	Node* find_by_key(Node* iter, key key)
	{
		if (key > iter->key)
		{
			if (iter->right == nullptr)
			{
				assert(!"No key found");
			}
			else
			{
				return find_by_key(iter->right, key);
			}
		}
		else if (key < iter->key)
		{
			if (iter->left == nullptr)
			{
				assert(!"No key found");
			}
			else
			{
				return find_by_key(iter->left, key);
			}
		}
		else
		{
			return iter;
		}
	}

public:
	void insert(key key, data data)
	{
		Node* new_node = new Node;
		new_node->key = key;
		new_node->data = data;
		if (_root == nullptr)
		{
			_root = new_node;
			return;
		}
		find_insert(_root, new_node);
	}
	
	data at(key key)
	{
		if (_root != nullptr)
			return find_by_key(_root, key)->data;
		else
			assert(!"No element in tree!");
	}

	void print(const std::string& prefix, const Node* node, bool isLeft)
	{
		if (node != nullptr)
		{
			std::cout << prefix;

			std::cout << (isLeft ? "|--" : "|__");

			std::cout << node->data << std::endl;

			print(prefix + (isLeft ? "|   " : "    "), node->left, true);
			print(prefix + (isLeft ? "|   " : "    "), node->right, false);
		}
	}
	void print()
	{
		if (_root != nullptr)
		{
			print("", _root, false);
		}
	}
};





int main()
{
	BinaryTree<int, string> tree;

	tree.insert(5, "Aftandil");
	tree.insert(6, "Israfil");
	tree.insert(8, "Elimemmed");
	tree.insert(7, "Almammad");
	tree.insert(4, "Ibrahim");

	//cout << tree.at(8) << endl;

	tree.print();

	//map<int, Student> a;
	//pair<int, Student> p;
	//p.first = 12; // key
	//p.second = Student(); // data
	//a.insert(p);
	//a.insert(pair<int, Student>(12, Student()));
	

	//cout << a.at(15); // out of range exception
	//cout << a.at(12);
	//cout << a.at(13);
	return 0;
}