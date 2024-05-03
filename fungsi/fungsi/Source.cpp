#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	char lanjut;
	double nilai;
	


	cout << "===== Selamat datang di aplikasi dadu =====" << endl;

	while (true)
	{
		cout << "lempar dadu?< y / n > : ";
		cin >> lanjut;

		if (lanjut == 'y')
		{
			cout << 1 + rand() % 6 << endl;
		}

		else if (lanjut == 'n')
		{
			cout << "selesai" << endl;
			break;
			
		}
		else 
		{
			cout << "undefenied" << endl;
		}

	}



	cin.get();
	return 0;

}