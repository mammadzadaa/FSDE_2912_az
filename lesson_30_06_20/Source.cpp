#include <iostream>

template <typename T>

class Array
{
private:
	T* data;
	size_t size;
public:
	Array() 
	{
		data = nullptr;
		size = 0;
	}
	Array(const Array& other)
	{
		this->data = new T[other.size]{};
		this->size = other.size;
		for (size_t i = 0; i < this.size; i++)
		{
			this->data[i] = other.data[i];
		}
	}
	Array(Array&& other)
	{
		delete[] this->data;
		this->data = other.data;
		this->size = other.size;
		other.data = nullptr;
	}
	~Array()
	{
		if(data != nullptr)
		delete[] data;
	}
	void Append(T val)
	{
		T* temp = new T[size + 1]{};
		for (size_t i = 0; i < size; i++)
		{
			temp[i] = data[i];
		}
		temp[size++] = val;
		delete[] data;
		data = temp;
	}
	size_t getSize()
	{
		return size;
	}
	void Append(const Array<T> &other)
	{
		// your code here
	}
	void Sort()
	{
		if (data[0] > data[1])
		{
			// some code
		}
		// > should be overloaded
		// your code here
	}
	
	Array<T>& operator=(Array&& other)
	{
		if (this == &other)
			return *this;

		delete[] this->data;

		this->data = other.data;
		this->size = other.size;
		other.data = nullptr;
	}

	Array<T> operator+(const Array<T>& other)
	{
		// your code here
	}
	T operator[](int index)
	{
		return data[index];
	}
};

class Fraction
{
private:
	int _suret;
	int _mexrec;
public:
	Fraction() = default;
	Fraction(int suret, int mexrec)
	{
		_suret = suret;
		_mexrec = mexrec;
	}
	bool operator>(const Fraction& other) const 
	{
		return true;
	}
	//friend void foo(Fraction&);
	//friend class Array<Fraction>;
};

//void foo(Fraction& f)
//{
//	f._suret = 12;
//}
//bool operator>(const Fraction& first,const Fraction& second) 
//{
//	return true;
//}

template <typename T>
T Add(T a, T b)
{
	return a + b;
}

template<>
char Add(char a, char b)
{
	return 'a';
}

int Add(int x, int y)
{
	return 5;
}

class Student
{
public:
	char* name;

};
	std::ostream& operator<<(std::ostream& out,const Student& s) 
	{
		out << s.name;
		return out;
	}


	Array<Fraction> FractionsCreator()
	{
		Array<Fraction> temp;
		temp.Append(Fraction(1, 2));
		temp.Append(Fraction(2, 3));
		temp.Append(Fraction(2, 7));
		return temp;
	}

int main()
{
	Array<Fraction> fr = FractionsCreator();

	Array<Fraction> fractions;

	fractions.Append(Fraction(1, 3));
	fractions.Append(Fraction(3, 7));
	fractions.Sort();

	/*Array<char> a;
	a.Append('A');
	a.Append('B');
	for (size_t i = 0; i < a.getSize(); i++)
	{
		std::cout << a[i] << std::endl;
	}
	a.Append('C');
	a.Append('D');
	std::cout << "//////////////////////\n";
	for (size_t i = 0; i < a.getSize(); i++)
	{
		std::cout << a[i] << std::endl;
	}

	Array<Student*> st;
	st.Append(new Student());
	st[0]->name = _strdup("Mecid");
	st.getSize();
	std::cout << st[0] << std::endl;*/

	//auto g = 5;
	//auto f = 'a';
	//Add(3, 5);

	return 0;
}