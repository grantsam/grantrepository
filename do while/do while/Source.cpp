#include <iostream>

using namespace std;

int main()
{
	int a;

	cout << "===selamat datang di materi DO while===" << endl;
	cout << "+PERINGATAN+" << endl;
	cout << "fungsi akan berjalan dengan rumus <nilai +1>" << endl;
	cout << "fungsi akan berhenti jika (a >= 10)" << endl;
	cout << "masukkan nilai : ";
	cin >> a;

	do 
	{
		cout << "perintah ini akan diulang" << endl;
		cout << "nilai diproses menjadi : " << a << endl;

		if (a >= 10)
		{
			break;
		}
	} while (a += 1);
	cout << "==========program telah selesai==========" << endl;

	cin.get();
	return 0;
}