#include <iostream>

using namespace std;

int main()
{
	float a = 10;
	float b = 5;
	int hasil; 
	float fhasil; // gunakan float pada perintah nilai dan perintah output jika ingin menghasilkan nilai desimal

	hasil = a + b;
	cout << a << "+" << b << "=" << hasil << endl;
	
	hasil = a - b;
	cout << a << "-" << b << "=" << hasil << endl;

	hasil = a * b;
	cout << a << "x" << b << "=" << hasil << endl;

	fhasil = a / b;
	cout << a << "/" << b << "=" << fhasil << endl;

	cin.get();
	return 0;
}