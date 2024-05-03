#include <iostream>
using namespace std;

int a;
int b;
int input;

int fungsi_ganjil()
{
	int nilaiganjil;
	
	cout << "jumlah deret = ";
	cin >> nilaiganjil; 
	for (int a = 1; a <= nilaiganjil; a += 2)
	{
		cout << a << "  ";

	}
	return a;
}

int fungsi_genap()
{
	int nilaigenap;
	cout << "deret = ";
	cin >> nilaigenap;
	for (int a = 0; a <= nilaigenap; a += 2)
	{
		cout << a << " ";
	}
	return a;
}

int main()
{
	cout << "ketik 1 untuk ganjil, ketik 2 untuk genap : ";
	cin >> input;
	if (input == 1)
	{
		cout << fungsi_ganjil();
		cout << "" << endl;
		cout <<"==============================================================================================================" << endl;
	}
	if (input == 2)
	{
		cout << fungsi_genap();
		cout << "" << endl;
		cout << "==============================================================================================================" << endl;
	}
	cout << "" << endl;
	cout << "ketik 3 untuk mengulang program = ";
	cin >> b;
	cout << "" << endl;
	cout << "==============================================================================================================" << endl;
	if (b == 3)
	{
		return main();
	}

	cin.get();
	return 0;
}