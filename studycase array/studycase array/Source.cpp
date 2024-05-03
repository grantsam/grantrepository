#include <iostream>
#include <array>
#include <string>
using namespace std;

int main()
{
	int b;
	string a;
	

	cout << "+++++ ENCRYPT / DECRYPT CODE +++++\n" << endl;
	cout << "plaintext : ";
	cin >> a;
	cout << endl << "key : ";
	cin >> b;
	cout << endl;

	for (int i = 0; i <= a.size(); i++)
	{
		a[i] = a[i] + b;
	}
	cout << "Result  : " << a << endl;
	


	cin.get();
	return 0;
}