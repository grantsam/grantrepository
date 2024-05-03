#include <iostream>

using namespace std;

int main()
{
	float a;
	float b;
	float diskon;
	float hasil;

	cout << "=====DISCOUNT CALCULATOR=====" << endl;
	cout << "masukkan harga barang : ";
	cout << "Rp.";
	cin >> a;
	cout << "masukkan besar diskon : ";
	cin >> b;

	diskon = a * b / 100;
	hasil = a -= diskon;
	cout << "harga barang menjadi : " << "Rp." << hasil << endl;

	cin.get();
	return 0;
}