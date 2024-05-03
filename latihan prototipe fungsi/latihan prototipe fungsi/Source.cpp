#include <iostream>
using namespace std;

int fungsix(int a, int b , int c)
{
	int fx;
	
	fx= a + b + c;
	cout << fx << "=" << a << "+" << b << "+" << c << endl;
    //cout << fx << endl;
	return fx;
}

void tampilkan(int a, int b, int c)
{
	cout << fungsix << endl;
}

int main()
{
	int ax, bx, cx, hasil;
	cout << "fx = ax^2+bx+c" << endl;
	cin >> ax;
	cin >> bx;
	cin >> cx;

	hasil = fungsix(ax, bx, cx);
	
	//cout << fungsix << endl;


	tampilkan(ax, bx, cx);

	cin.get();
	return 0;
}