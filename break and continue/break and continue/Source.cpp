#include <iostream>

using namespace std;

int main()
{
	cout << "=====selamat datang di materi break and continue=====" << endl;
	cout << "" << endl;

	cout << "fungsi break" << endl;
	cout << "fungsi akan stop di angka 5 akibat break;" << endl;
	for (int a = 0; a <= 10; a++)
	{
		cout << a << endl;
		if (a == 5) { break; }
		
	}

	cout << "" << endl;
	cout << "fungsi continue" << endl;
	cout << "fungsi akan lanjut di angka 5, angka 5 diproses dan tidak akan ditampilkan " << endl;
	for (int b = 0; b <= 10; b++)
	{
		
		if (b == 5) 
		{
			cout << "=angka diproses=" << endl;
			continue;
		}
		cout << b << endl;
	}


	cin.get();
	return 0;
}