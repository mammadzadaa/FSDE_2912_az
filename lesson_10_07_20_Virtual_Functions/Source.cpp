#include<iostream>

using std::cout;

template<typename T>
class LinkedList
{
protected:
	struct Node
	{
		T date;
		Node* next;
	};
	Node* _start;
};

template<typename T>
class DLinkedList : public LinkedList<T>
{

};

class ProgrammingLanguage
{
public:
	virtual void whoAmI()
	{
		cout << "I am a Programming Language\n";
	}
};

class CPP : public ProgrammingLanguage
{
public:
	void whoAmI()
	{
		cout << "I am CPP \n";
	}
};

class Java : public ProgrammingLanguage
{
public:
	void whoAmI()
	{
		cout << "I am Java \n";
	}
};

class CSharp : public ProgrammingLanguage
{
public:
	void whoAmI()
	{
		cout << "I am C# \n";
	}
};

//void foo() {};
//int foo(int a = 1) { return 0; }

class Weapon // abstract class
{
protected:
	int _damage;
	char* _name;
public:
	Weapon(int damage, const char* name)
	{
		_damage = damage;
		_name = _strdup(name);
	}
	~Weapon() { delete[] _name; }
	char* getName()
	{
		return _name;
	}
	virtual int getDamage() = 0 /* pure virtual */ { return _damage; }
};

class Sward : public Weapon
{
public:
	Sward(int damage) : Weapon(damage, "Sward") {}
	int getDamage() override { return Weapon::getDamage(); }
};

class Nunchaku : public Weapon
{
public:
	Nunchaku(int damage) : Weapon(damage, "Nunchaku") {}
	int getDamage() override { return Weapon::getDamage(); }
};

class Bow : public Weapon
{
public:
	Bow(int damage) : Weapon(damage, "Bow") {}
	int getDamage() override { return Weapon::getDamage(); }
};

class Fighter // abstract
{
protected:
	Weapon* _weapon;
public:
	Fighter(Weapon* weapon) : _weapon(weapon) {}
	virtual void Atack() = 0 /*pure virtual function*/ 
		{ cout << "Figter atacks with " << _weapon->getName() << " that damaged " 
		<< _weapon->getDamage() << " points" << "\n"; }
};

class SwardMan : public Fighter
{
public:
	SwardMan(Weapon* weapon) : Fighter(weapon) {}
	void Atack() override {
		cout << "SwardMan atacks with " << _weapon->getName() << " that damaged "
			<< _weapon->getDamage() << " points" << "\n";
	}
};

class Archer : public Fighter
{
public:
	Archer(Weapon* weapon) : Fighter(weapon) {}
	void Atack() override {
		cout << "Archer atacks with " << _weapon->getName() << " that damaged "
			<< _weapon->getDamage() << " points" << "\n";
	}
};

class Ninja : public Fighter
{
public:
	Ninja(Weapon* weapon) : Fighter(weapon) {}
	void Atack() override {
		cout << "Ninja atacks with " << _weapon->getName() << " that damaged "
			<< _weapon->getDamage() << " points" << "\n";
	}
};

class Warior : public Fighter
{
public:
	Warior(Weapon* weapon) : Fighter(weapon) {}
	void Atack() override {
		cout << "Warior atacks with " << _weapon->getName() << " that damaged "
			<< _weapon->getDamage() << " points" << "\n";
	}
};

class Army 
{
private:
	Fighter** _army = nullptr;
	size_t size = 0;
public:
	void addFighter(Fighter* fighter)
	{
		Fighter** temp = new Fighter * [size + 1]{};
		for (size_t i = 0; i < size; i++)
		{
			temp[i] = _army[i];
		}
		temp[size++] = fighter;
		delete[] _army;
		_army = temp;
	}
	void armyAttack()
	{
		for (size_t i = 0; i < size; i++)
		{
			_army[i]->Atack();
		}
	}

};

int main()
{
	Army army;
	army.addFighter(new SwardMan(new Sward(60)));
	army.addFighter(new SwardMan(new Sward(65)));
	army.addFighter(new Archer(new Bow(25)));
	army.addFighter(new SwardMan(new Sward(70)));
	army.addFighter(new Ninja(new Nunchaku(45)));
	army.addFighter(new Ninja(new Nunchaku(30)));
	army.addFighter(new Archer(new Bow(30)));
	army.addFighter(new Ninja(new Nunchaku(40)));
	army.addFighter(new Warior(new Sward(70)));
	
	//army.addFighter(new Fighter(new Weapon(10,"name"))); // not good idea at all

	army.armyAttack();


	//foo();

	//ProgrammingLanguage p;
	//CPP c;
	//Java j;

	//p.whoAmI();
	//c.whoAmI();
	//j.whoAmI();

	/////////////////////////

	//ProgrammingLanguage* pl = new ProgrammingLanguage();
	//ProgrammingLanguage* plc = new CPP();
	//ProgrammingLanguage* plj = new CSharp();
	//

	//pl->whoAmI();
	//plc->whoAmI();
	//plj->whoAmI();

	/////////////////////////////

	/*ProgrammingLanguage** arr = new ProgrammingLanguage * [4]{};
	arr[0] = new ProgrammingLanguage();
	arr[1] = new CPP();
	arr[2] = new Java();
	arr[3] = new CSharp();

	for (size_t i = 0; i < 4; i++)
	{
		arr[i]->whoAmI();
	}*/


	return 0;
}