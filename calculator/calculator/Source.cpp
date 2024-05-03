#include <iostream>

using namespace std;

int main()
{
	float a;
	float b;
	float hasil;
	char oper;

	cout << "=====CALCULATOR=====" << endl;
	cout << "masukkan nilai pertama:";
	cin >> a; 
	cout << "pilih operator +,-,*,/ :";
	cin >> oper; 
	cout << "masukkan nilai kedua :";
	cin >> b;  


	switch (oper)
	{
	case '+':
		hasil = a + b;
	case '-':
		hasil = a - b;
	case '/':
		hasil = a / b;
	case '*':
		hasil = a * b;
	default:
			cout << "tidak ditemukan" << endl;
			break;
	}
	cout << a << oper << b << " = " << hasil << endl;
	cout << "++++++++++++++";

	cin.get();
	return 0;
}