#include <iostream>
using std::cout;

//
//class DB
//{
//public:
//	virtual void printMyName() const
//	{
//		cout << "My name is DB\n";
//	}
//};
//
//class MYSQL : public DB
//{
//public:
//	virtual void printMyName() const override final
//	{
//		cout << "My name is MYSQL\n";
//	}
//	void MySqlSpecific() const
//	{
//		cout << "MYSQL specific\n";
//	}
//};
//
//class Oracle : public DB
//{
//public:
//	virtual void printMyName() const override final
//	{
//		cout << "My name is Oracle\n";
//	}
//	void OracleSpecific() const
//	{
//		cout << "Oracle specific\n";
//	}
//};
//

//void foo(const DB* db)
//{
//	db->printMyName();
//	
//	DB* d = const_cast<DB*>(db);
//	MYSQL* ms = dynamic_cast<MYSQL*>(d);
//	if (ms)
//	{
//		ms->MySqlSpecific();
//	}
//	else
//	{
//		Oracle* o = dynamic_cast<Oracle*>(d);
//		if (o)
//		{
//			o->OracleSpecific();
//		}
//		else
//		{
//			cout << "Sorry it was DB class\n";
//		}
//	}
//	cout << "\n////////////////////////////////\n\n";
//}


class A
{
private:
	int pr;
protected:
	int num;
public:
	int p_num;
};

class B : public A
{
public:
	int _num;
};

int main()
{
	cout << sizeof(B);
	/*DB** dbs = new DB * [3]{};
	dbs[0] = new MYSQL();
	dbs[1] = new Oracle();
	dbs[2] = new DB();

	for (size_t i = 0; i < 3; i++)
	{
		foo(dbs[i]);
	}*/


	/*int num = 65;
	int* ptr = &num;
	char* c_ptr = reinterpret_cast<char*>(ptr);
	printf("%s\n", c_ptr);*/

	return 0;
}