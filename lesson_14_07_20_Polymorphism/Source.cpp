#include<iostream>
#include<list>
using namespace std;
class Human {
private:
	char* _name;
public:
	char* getName() const {
		return _name;
	}
	void setName(char* name) {
		delete[] _name;
		_name = _strdup(name);
	}

	Human(char* name) {
		_name = new char[strlen(name) + 1];
		strcpy_s(_name, (strlen(_name) + 1), name);
	}

	Human(Human& other) {
		delete[] _name;
		this->_name = _strdup(other._name);
	}

	Human(Human&& other) {
		setName(other._name);
		other._name = nullptr;
	}
};

// By Elnur

//class Inqridient abstract
//{
//protected:
//	int _kkal;
//	int _yag;
//	int _zulal;
//public:
//	Inqridient(int kkal, int yag, int zulal)
//	{
//		_kkal = kkal;
//		_yag = yag;
//		_zulal = zulal;
//	}
//	~Inqridient()
//	{
//		_kkal = 0;
//		_yag = 0;
//		_zulal = 0;
//	}
//};
//class Yemek {
//private:
//	const char* _name;
//public:
//	struct 	Inqridient_qram
//	{
//		Inqridient* inq;
//		int qram;
//	};
//private:
//	list<Inqridient_qram> _inq;
//public:
//	Yemek(const char* name, list<Inqridient_qram> list_of_ingridients)
//	{
//		_name = _strdup(name);
//		_inq = list_of_ingridients;
//	}
//	virtual void Show() = 0;
//};
//class Menu
//{
//private:
//	int _qiymeti;
//	
//	
//
//public:
//	struct Yemek_list
//	{
//		Yemek* yem;
//		int porsion;
//	};
//private:
//	list<Yemek_lst > yemek;
//public:
//
//	Menu(int qiymeti,int porsion)
//	{
//		_qiymeti = qiymeti;
//		
//	}
//	Add_yemek(Yemek* y)
//	{
//	
//	}
//};
//

// By Elnur