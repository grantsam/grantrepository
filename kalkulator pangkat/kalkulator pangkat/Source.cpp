#include <iostream>
using namespace std;

int rumuspangkat(int a, int b)
{
	if (b <= 1)
	{
		return a;
	}
	return a * rumuspangkat(a, b - 1);
}



int main()
{
	
	int a, b;

	
	cout << "==========Selamat datang di kalkulator pangkat==========" << endl;
	cout << "masukkan angka : ";
	cin >> a;
	cout << "masukkan nilai pangkat : ";
	cin >> b;
	cout << "hasil : " << rumuspangkat(a, b) << endl;
	cout << "spesifikasi hasil : ";
	if (rumuspangkat(a, b) % 2 == 0)
	{
		cout << "nilai genap" << endl;
	}
	else
	{
		cout << "nilai ganjil" << endl;
	}
		char kembali;
		cout << "ketik y untuk ulang n untuk selesai : ";
		cin >> kembali;
		if (kembali == 'y')
		{
			cout << "========================================================================================================================\n" << endl;
			return main();
		}
		else if (kembali == 'n')
		{

			cout << "Selesai" << endl;
			cout << "========================================================================================================================\n" << endl;
		}
		else
		{
			cout << "========================================================================================================================\n" << endl;
			cout << "Eror" << endl;
			cout << "========================================================================================================================\n" << endl;

		}


	

	cin.get();
	return 0;
}







