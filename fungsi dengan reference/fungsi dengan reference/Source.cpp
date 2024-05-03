#include <iostream>
using namespace std;

void kuadrat(int &bnilai)
{
	bnilai = bnilai * bnilai;
}

int  main()
{
	int a = 9;
	cout << "+++++ MATERI REFERENCE ++++++\n\n\n" << endl;
	cout << "alamat a = " << &a << endl;
	cout << "nilai a  = " << a << endl;

	kuadrat(a);
	cout << "alamat a = " << &a << endl;
	cout << "nilai kuadrat a  = " << a << endl;


	cin.get();
	return 0;
}