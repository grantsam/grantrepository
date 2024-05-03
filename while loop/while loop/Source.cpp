#include <iostream>

using namespace std;

int main()
{
	int a;

	cout << "===selamat datang di materi while===" << endl;
	cout << "+PERINGATAN+" << endl;
	cout << "fungsi akan berjalan dengan rumus <nilai +1>" << endl;
	cout << "fungsi akan berhenti jika (a >= 10)" << endl;
	cout << "masukkan nilai : ";
	cin >> a;

	while (a < 10)
	{
		cout << "perintah ini akan diulang" << endl;
		cout << "nilai diproses menjadi : " << a << endl;
		a += 1;

		if (a >= 10) 
		{
			cout << "==========program telah selesai==========" << endl;
		}


	}


	cin.get();
	return 0;
}