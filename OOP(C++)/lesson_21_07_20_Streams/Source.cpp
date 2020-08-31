#include<iostream>
#include<list>
#include <iomanip>
#include <string>
#include <sstream>

using namespace std;

class Student
{
private:
	char* _name;
	char* _surname;
	unsigned short _age;
public:
	Student() : Student(nullptr, nullptr, 0) {}
	Student(const char* name, const char* surname, unsigned short age)
	{
		_name = _strdup(name);
		_surname = _strdup(surname);
		_age = age;
	}
	~Student()
	{
		delete[] _name;
		delete[] _surname;
	}
	Student(Student& other)
	{
		delete[] _name;
		delete[] _surname;
		_name = _strdup(other._name);
		_surname = _strdup(other._surname);
	}

	char* getName()
	{
		return _name;
	}
	char* getSurname()
	{
		return _surname;
	}
	unsigned short getAge()
	{
		return _age;
	}

};

class Group
{
public:
	std::list<Student*> students;
	bool writeStudentsToFile(const char* file_name)
	{
		FILE* file;
		fopen_s(&file, file_name, "wb");
		if (file == nullptr)
			return false;

		auto size = students.size();
		fwrite(&size, sizeof(size_t), 1, file);

		for (auto i : students)
		{
			size_t name_len = strlen(i->getName());
			fwrite(&name_len, sizeof(size_t), 1, file);
			fwrite(i->getName(), sizeof(char), name_len, file);

			size_t surname_len = strlen(i->getSurname());
			fwrite(&surname_len, sizeof(size_t), 1, file);
			fwrite(i->getSurname(), sizeof(char), surname_len, file);

			unsigned short age = i->getAge();
			fwrite(&age, sizeof(unsigned short), 1, file);
		}
		fclose(file);
		return true;
	}
	bool readStudentsFromFile(const char* file_name)
	{
		FILE* file;
		fopen_s(&file, file_name, "rb");
		if (file == nullptr)
			return false;

		size_t size;
		fread(&size, sizeof(size_t), 1, file);

		for (size_t i = 0; i < size; i++)
		{
			size_t name_len;
			fread(&name_len, sizeof(size_t), 1, file);
			char* name = new char[name_len + 1]{};
			fread(name, sizeof(char), name_len, file);

			size_t surname_len;
			fread(&surname_len, sizeof(size_t), 1, file);
			char* surname = new char[surname_len + 1]{};
			fread(surname, sizeof(char), surname_len, file);

			unsigned short age;
			fread(&age, sizeof(unsigned short), 1, file);

			students.push_back(new Student(name, surname, age));
			delete[] name;
			delete[] surname;
		}

		fclose(file);
		return true;
	}
	void printStudents()
	{
		for (auto i : students)
		{
			cout << i->getName() << ' ' << i->getSurname() << ' ' << i->getAge() << endl;
		}
	}
};

int main()
{
	string s;
	char arr[100]{};

	//getline(cin, s);
	//
	//cout << s << endl;

	/*cin.get(arr, 100);
	cout << arr << endl;
	cout << cin.gcount() << endl;*/

	//std::cin >> std::ws;
	//cin.putback('A');
	//cout << cin.peek() << endl;
	//cout << cin.gcount() << endl;
	//cin.unget();

	/*cout << true << endl;
	cout.setf(ios::boolalpha);
	cout << false << endl;

	cout << 15 << endl;
	cout.unsetf(ios::dec);
	cout.setf(ios::hex);
	cout << 15 << endl;
	*/

	/*cout.setf(ios::fixed);

	cout << setprecision(2) << 123456 << endl;
	printf("%5d\n%15d\n",12,14);*/

	stringstream os;

	os << "Metn " << 122 << " hmm " << 45.21 << "\n";
	
	cout << os.str();
	os.clear();

	int a = 32;
	short f = 12;
	double d = 34.67;
	string str = "Aftandli Mammadov";

	os << a << " then " << f << " then " << d << " then " << str << endl;

	
	cout << os.str();

	int num;

	while (true)
	{
		cin >> num;
		if (cin.fail())
		{
			cin.clear();
			cin.ignore(32767, '\n');
			continue;
		}
		break;
	}



	/*Group group;

	group.students.push_back(new Student("Aftandli","Mammadov",25));
	group.students.push_back(new Student("Israfil", "Abiyev", 23));
	group.students.push_back(new Student("Mahmud", "Mustafazade", 21));

	group.printStudents();
	group.writeStudentsToFile("student.bin");

	cout << "\n\nAnother group: \n\n";

	Group group_2;
	group_2.readStudentsFromFile("student.bin");
	group_2.printStudents();*/

	return 0;
}