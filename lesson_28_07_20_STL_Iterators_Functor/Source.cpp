#include <iostream>
#include<list>
#include<vector>
#include <string>
#include<algorithm>


//class Inqridiyent
//{
//private:
//	std::string _name;
//};
//
//struct InqridiyentMiqdar
//{
//	Inqridiyent* inqridiyent;
//	unsigned short qramm;
//};
//
//class Yemek_qiymetsiz
//{
//protected:
//	std::string _name;
//	std::list<InqridiyentMiqdar> _list_inqridiyent_miqdar;
//public:
//	std::list<InqridiyentMiqdar> getList()
//	{
//		return _list_inqridiyent_miqdar;
//	}
//	std::string getName()
//	{
//		return _name;
//	}
//};
//
//class Yemek : public Yemek_qiymetsiz
//{
//private:
//		unsigned short _qiymet;
//public:
//	unsigned short getQiymet()
//	{
//		return _qiymet;
//	}
//};

//void foo_Metbex(Yemek_qiymetsiz& yemek) 
//{
//	yemek.getQiymet();
//	yemek.getList();
//	yemek.getName();
//}
//void foo_Menyu(Yemek& yemek) 
//{
//	yemek.getQiymet();
//	yemek.getList();
//	yemek.getName();
//}

class Aftandil
{
public:
	std::string name;
	Aftandil(std::string n) : name(n) {}
};

int increment(int x)
{
	return x + 1;
}
int increment5(int x, int y)
{
	return x + 5;
}

class increment_functor
{
private:
	int _num;
public:
	increment_functor(int num) : _num(num) {}
	int operator()(int arr_num) const
	{
		return arr_num + _num;
	}
};

template<class T>
void print_arr(int* arr, int size, T func)
{
	for (size_t i = 0; i < size; i++)
	{
		std::cout << func(arr[i]) << " ";
	}
	std::cout << std::endl;
}

int main()
{
	int arr[] = { 1,2,3,4,5 };
	int size = sizeof(arr) / sizeof(arr[0]);
	
	for (auto i : arr) 
	{
		std::cout << i << " ";
	}
	std::cout << std::endl;

	print_arr(arr, size, increment5);

	/*std::transform(arr, arr + size, arr, increment_functor(5));

	for (auto i : arr)
	{
		std::cout << i << " ";
	}
	std::cout << std::endl;*/


	/*std::list<int> numbers;

	numbers.push_back(12);
	numbers.push_back(13);
	numbers.push_back(14);
	numbers.push_back(15);
	numbers.push_back(16);

	for (auto i = numbers.begin(); i != numbers.end(); i++)
	{
		std::cout << *i << " ";
	}*/

	/*std::list<Aftandil> list;
	list.push_back(Aftandil("Ibish"));
	list.push_back(Aftandil("Cebish"));
	list.push_back(Aftandil("Mirsaleh"));

	for (auto i : list)
	{
		std::cout << i.name << "\n";
	}
	std::cout << "\n\n\n";

	list.erase(list.begin());

	for (auto i : list)
	{
		std::cout << i.name << "\n";
	}*/

	/*Yemek y;
	foo_Menyu(y);
	foo_Metbex(y);*/

	/*std::list<int> list;
	list.push_front(12);
	list.push_front(13);
	list.push_front(14);
	list.push_front(15);

	auto iter = list.begin();

	iter++;
	iter++;

	*iter -= 2;

	list.erase(iter);

	for (auto i : list)
	{
		std::cout << i << " ";
	}
	
	std::cout << std::endl;*/

	return 0;
}