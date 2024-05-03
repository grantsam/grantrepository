#include <iostream>

using namespace std;

int main()
{

	int a;
	bool out1 =true;
	
	
	    cout << "tekan 1" << endl;
		cout << "masukkan angka" << endl;
		cin >> a;

		

		int code1 = out1;

		switch (a)
		{
		case 1:
			cout << "ini adalah 1 " << endl;
			break;
		default:
			cout << out1 << endl; //problem
			if (out1 == true)
				cout << "ulang" << endl;
		}
		if (code1)
			cout << main << endl;

	cin.get();
	return 0;
}