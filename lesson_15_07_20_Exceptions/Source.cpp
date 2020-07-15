#include <vector>
#include <string>
#include<iostream>
#include<assert.h>

using std::vector;
using std::string;
using std::cout;

class Ingridient abstract
{
private:
	int _kkal;
	string _name;
public:
	Ingridient(string name, int kkal)
	{
		_name = name;
		_kkal = kkal;
	}
	int getKkal() { return _kkal; }
	string getName() { return _name; }
	virtual ~Ingridient() {}
};

class Pomidor : public Ingridient
{
public:
	Pomidor() : Ingridient("Pomidor",18) {}
};

class Soghan : public Ingridient
{
public:
	Soghan() : Ingridient("Soghan", 55) {}
};

class Egg : public Ingridient
{
public:
	Egg() : Ingridient("Egg", 72) {}
};

class Oil : public Ingridient
{
public:
	Oil() : Ingridient("Oil", 119) {}
};

class Yemek abstract
{
public:
	struct Ingridient_Qramm
	{
		Ingridient* inqridiyent = nullptr;
		int qramm = 0;
	};
protected:
	string _name;
	vector<Ingridient_Qramm*> _ingridient_vector;
public:
	Yemek(string name) { _name = name; }
	virtual ~Yemek() {}
	void show()
	{
		int s_qramm = 0;
		int s_kkal = 0;
		cout << "The meal called " << _name << " has ingridients: \n";
		for (auto itm : _ingridient_vector)
		{
			cout << itm->inqridiyent->getName() << "\n";
			s_kkal += ((itm->inqridiyent->getKkal()) * (itm->qramm) / 100);
			s_qramm += itm->qramm;
		}
		cout << "Meal also is " << s_qramm << " qramms and has " << s_kkal << " kkal\n";
	}
};

class PomidorChighirtmasi : public Yemek
{
public:
	PomidorChighirtmasi() : Yemek("Pomidor chighirtmasi")
	{
		
		Yemek::Ingridient_Qramm* iq = new Yemek::Ingridient_Qramm();
		iq->inqridiyent = new Pomidor();
		iq->qramm = 200;
		_ingridient_vector.push_back(iq);
		Yemek::Ingridient_Qramm* iq_s = new Yemek::Ingridient_Qramm();
		iq_s->inqridiyent = new Soghan();
		iq_s->qramm = 50;
		_ingridient_vector.push_back(iq_s);
		Yemek::Ingridient_Qramm* iq_e = new Yemek::Ingridient_Qramm();
		iq_e->inqridiyent = new Egg();
		iq_e->qramm = 80;
		_ingridient_vector.push_back(iq_e);
		Yemek::Ingridient_Qramm* iq_o = new Yemek::Ingridient_Qramm();
		iq_o->inqridiyent = new Oil();
		iq_o->qramm = 30;
		_ingridient_vector.push_back(iq_o);
	}
};


class Human
{
private:
	char* _name;
public:
	Human(const char* name)
	{		
		//assert(name != nullptr && "Human name can't have nullptr as name!");
		if (name == nullptr)
		{
			std::exception ex("Exception: Human name can't have nullptr as name!");

			string s = "Human name can't have nullptr as name!";
			throw ex;
			throw s;
			throw 12;
		}
		cout << "Constructor worked!\n";
		_name = _strdup(name);
	}
	~Human() { delete[] _name; }
	char* getName()
	{
		return _name;
	}
};


int main()
{
	try
	{
		Human human(nullptr);
		cout << human.getName();
	}
	catch (const string &s)
	{
		cout << s;
	}
	catch (int a)
	{
		cout << a << "\n";
	}
	catch (const std::exception& ex)
	{
		cout << ex.what() << "\n";
	}
	



	/*Yemek* yemek = new PomidorChighirtmasi();
	yemek->show();*/
	return 0;
}