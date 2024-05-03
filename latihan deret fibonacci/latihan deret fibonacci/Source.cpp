#include <iostream>

using namespace std;
int main()
{
	int f_n;
	int f1_n;
	int f2_n;
	int n;

	cout << "=====DERET FIBONACCI=====" << endl;
	cout << "Masukkan nilai n : ";
	cin >> n;

	f1_n = 1;
	f2_n = 0;
	f_n = f1_n + f2_n;
	cout << f2_n << " ";
	cout << f_n << " ";

	for (int i = 1; i < n; i++)
	{

		f_n = f1_n + f2_n;
		f2_n = f1_n;
		f1_n = f_n;

		cout << f_n << " ";
	}
	cout << "\n";
	cin.get();
	return 0;
}