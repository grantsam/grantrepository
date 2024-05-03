#include <iostream>
using namespace std;

int faktorial(int a)
{
	if (a <= 1)
	{
		cout << a << " = ";
		return a;
	}
	else
	{
		cout << a << " * ";
		return a * faktorial(a - 1);
	}
}

void y()
{
	int ulang = 0;
	cout << " tekan 0 untuk ulang program : ";
	cin >> ulang;
}


int main()
{
	int angka;
	int ulang;
	
	cout << "====== Mesin Faktorial =====" << endl;
	cout << "masukkan angka yang ingin difaktorialkan : ";
	cin >> angka;
	cout << "Hasil faktorial : ";
	cout << faktorial(angka) << endl;
	cout << "=================================================" << endl;
	cout << "=================================================" << endl;

	cout << " tekan 1 untuk ulang program : ";
	cin >> ulang;

	while (ulang != 1)
	{
		cout << " tekan 1 untuk ulang program : ";
		cin >> ulang;

		if (ulang == 1)
		{
			return main();
		}
		else
		{
			cout << "unidentified" << endl;
		}
	}
	
	cin.get();
	return 0;
}




