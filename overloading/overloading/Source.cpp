#include <iostream>
using namespace std;

//basic function
int luas_balok(double panjang, double lebar, double tinggi)
{
	int luas = panjang * lebar * tinggi;
		return luas;
}

//overload function / menimpa
int luas_kubus(double panjang)
{
	int luas = panjang * panjang * panjang;
	return luas;
}

int main()
{
	cout << "selamat datang di materi overload" << endl;
	cout << "" << endl;
	cout << " luas balok = " << luas_balok(2, 3, 4) << endl;
	cout << " luas kubus = " << luas_kubus(2) << endl;
	cin.get();
	return 0;
}