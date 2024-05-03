#include <iostream>
using namespace std;

int blockline();

int main() 
{
	int n;
	cout << "masukkan nilai : ";
	cin.clear();
	cin >> n;
	cin.clear();
	int fn1 = 1;
	int fn0 = 0;

	for (int i = 1; i <= n; i++)
	{


		int fn;

		fn = fn1 + fn0;
		fn0 = fn1;
		fn1 = fn;

		cout << "hasil : " << fn << endl;
		if (i == n)
		{
			break;
		}
	}
	cin.clear();

	blockline();
	
}

int blockline()
{
	int b;
	cout << "ulang? y / n : ";
	cin >> b;

	switch (b)
	{
	case 'y':
		return main();
	case 'n':
		cout << "selesai" << endl;
		return 0;
	default:
		return blockline();
	}
}