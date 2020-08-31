#include<iostream>
using namespace std;

class my_out_of_bound : public exception
{
private:
	const char* m_message = nullptr;
public:
	my_out_of_bound(int index, int min, int max)
	{
		char* buf = new char[256];
		sprintf_s(buf, 256, "This index %d is out of range between %d and %d", index, min, max);
		m_message = _strdup(buf);
		delete[] buf;
	}
	virtual const char* what() const override
	{
		return m_message;
	}
	~my_out_of_bound()
	{
		delete[] m_message;
	}
};

template <typename T, size_t size>
class Array
{
	T m_arr[size]{};
	size_t m_size = size;
public:
	T at(size_t index)
	{
		if (index < 0 || index >= m_size)
			throw my_out_of_bound(index, 0, m_size - 1);
		return m_arr[index];
	}
};
class Aftandil{};

class FileException : public exception
{
	char* _msj;
public: 
	FileException(const char* fname) {
		_msj = _strdup(fname);
	}

	const char* what () const override {
		return _msj;
	}
	~FileException()
	{
		delete[] _msj;
	}
};

char* fileReader(const char* file_name)  //throw(...)  //noexcept
{
	FILE* file;
	fopen_s(&file, file_name, "rb");
	if (file == nullptr);
	{
		throw FileException(file_name);
	}

	char buf[255]{};
	fgets(buf, 255, file);
	return buf;
}

class A
{
private:
	char* _name;
public:
	A() = default;
	A(const char* name) 
	{
		if (name == nullptr)
		{
			throw exception("Null Pointer");
		}
		_name = _strdup(name); 
	}
	~A() { delete[] _name; }
};

class B : public A
{
public:
	B(const char* name) try : A(name) {}
	catch (const std::exception& ex)
	{
		cout << ex.what() << endl;
	}
};


namespace my 
{

	class exception
	{

	};

}

namespace my
{
	class array
	{

	};
}

namespace my
{
	class My
	{

	};
}

namespace my
{
	void print()
	{
		cout << "My print\n";
	}
}

namespace yours
{
	void print()
	{
		cout << "Yours print\n";
	}
}

void print()
{
	cout << "Global print\n";
}

//using namespace my;

using my::My;

using namespace yours;

namespace a {
	void foo() {}

	namespace b_nested
	{
		void foo() {}
	}
}

namespace
{
	void func() {}
}

inline namespace s
{
	void function() {}
}

int main()
{
	func();
	s::function();

	::print();
	my::print();
	yours::print();
	a::foo();
	a::b_nested::foo();
	namespace b_alias = a::b_nested;
	b_alias::foo();



	/*My m;
	std::exception ex;
	my::exception exp;
	
	my::array ar;*/
	
	
	//B b(nullptr);

	//try
	//{
	//	B b(nullptr);
	//}
	//catch (const std::exception& ex)
	//{
	//	cout << ex.what();
	//}

	/*try
	{
		try
		{
			fileReader("Text.bin");
		}
		catch (const std::exception& ex)
		{
			cout << ex.what() << endl;
			throw;
		}
	}
	catch (const std::exception& ex)
	{
		cout << ex.what() << endl;
	}*/
	

	//Array<Aftandil, 10> arr;
	//try
	//{
	//	arr.at(11);
	//}
	//catch (const my_out_of_bound& ex)
	//{
	//	cout << ex.what() << endl;
	//}

	return 0;
}
