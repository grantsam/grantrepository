#include <iostream>
using namespace std;

int Volume_balok(int a = 1, int b = 1, int c = 1) //masukkan nilai pada int untuk mengatur nilai default
{
	return a * b * c;
}

int main()
{
	cout << "volume balok : " << Volume_balok(4,5,6) << endl; // jika nilai dimasukkan 
	cout << "volume balok : " << Volume_balok() << endl; //jika tidak ada nilai yg dimasukkan maka program akan memproses nilai default
	return 0;
}