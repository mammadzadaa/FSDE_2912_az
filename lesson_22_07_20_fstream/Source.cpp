#include <iostream>
#include <sstream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	size_t size;
	char* str;
	fstream fs("text.bin", ios_base::in | ios_base::binary);

	if (fs.is_open()) {
		fs.read((char*)&size, sizeof(size_t));
		str = new char[size + 1]{};
		fs.read(str, size);
		/*fs.seekg();*/
		fs.close();

		cout << str << endl;
	}



	/*string s("Aftandil Mammadov");
	size_t s_len = s.size();

	fstream fs("text.bin", ios_base::out | ios_base::binary);
	if (fs.is_open()) {
		fs.write((char*)&s_len, sizeof(size_t));
		fs.write(s.c_str(), s_len);
		fs.close();
	}*/
	


	//char buf[255]{};
	//fstream fs("student.bin",ios_base::in /*read*/| ios_base::binary);
	//if (fs.is_open())
	//{
	//	fs.read(buf,255);
	//	fs.close();
	//}
	//string s(buf);
	//
	//cout << s << endl;

	//string s("Aftandil");
	//fstream f("student.bin",ios_base::out /*write*/ | ios_base::binary); // bitwise operators & | ^ tekrar edin
	//if (f.is_open())
	//{
	//	f.write(s.c_str(),s.size());
	//	f.close();
	//}

	//ofstream f("mehrac.txt");
	//f << "Salam Mehrac. ";
	//f << "Necesen? ";
	//f << "Derse niye hazir deyilsen?";
	//f.flush();
	//f.close();

	/*ifstream f("mehrac.txt");

	string str;

	getline(f, str);

	cout << str << endl;

	f.close();*/

	/*FILE* f;
	char str[20]{};
	strcpy_s<20>(str, "Aftandil Mammadov");
	fopen_s(&f, "file.mehrac", "wb");
	int adamuzunlugu = strlen(str);
	fwrite(&adamuzunlugu, sizeof(int), 1, f);
	fwrite(&str, sizeof(char), adamuzunlugu, f);
	fclose(f);
	f = nullptr;
	char* neww;
	fopen_s(&f, "file.mehrac", "rb");
	if (f == nullptr)
	{
		cout << "Error!\n";
		return 0;
	}
	fread(&adamuzunlugu,sizeof(int),1,f);
	cout << adamuzunlugu << endl;
	neww = new char[adamuzunlugu + 1]{};
	fread(neww, sizeof(char), adamuzunlugu, f);
	cout << neww<<endl;
	fclose(f);*/

	/*stringstream os;

	os << "Salama dunya! Necesiz eziz telebeler?";
	os.seekg(-24, ios_base::end);
	os << " Hello world";
	os.seekg(0, ios_base::beg);

	string s;
	getline(os, s);

	cout << s << endl;*/

	return 0;
}
