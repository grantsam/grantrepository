#include <iostream>
using namespace std;

//fungsi iterasi
int pangkatiterasi(int a, int b)
{
	int hasil = a;
	for (int i = 1; i < b; i++)
	{
		hasil = hasil * a;
	}
	return hasil;
}

//fungsi rekursif
int pangkatrekursif(int a, int b)
{
	if (b <= 1)
	{
		return a;
	}

	return a * pangkatrekursif(a, b - 1);
	
}

int main()
{
	cout << pangkatiterasi(2, 6) << endl;
	cout << pangkatrekursif(2, 6) << endl;

	cin.get();
	return 0;
}