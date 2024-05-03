#include <iostream>
using namespace std;

int main()
{
	int nilai[5] = {0,1,2,3,4,};
	cout << "+++++ PENDAHULUAN ARRAY ++++++\n\n\n" << endl;
	cout << &nilai[0] << " nilai array : " << nilai[0] << endl;
	cout << &nilai[1] << " nilai array : " << nilai[1] << endl;
	cout << &nilai[2] << " nilai array : " << nilai[2] << endl;
	cout << &nilai[3] << " nilai array : " << nilai[3] << endl;
	cout << &nilai[4] << " nilai array : " << nilai[4] << endl;

	cout << "\n update nilai 4" << endl;
	nilai[4] = 8; //update 
	cout << &nilai[0] << " nilai array : " << nilai[0] << endl;
	cout << &nilai[1] << " nilai array : " << nilai[1] << endl;
	cout << &nilai[2] << " nilai array : " << nilai[2] << endl;
	cout << &nilai[3] << " nilai array : " << nilai[3] << endl;
	cout << &nilai[4] << " nilai array : " << nilai[4] << endl;
	cout << endl;
	cout << "besar memori array ini = " << sizeof(nilai) << endl;
	cout << "jumlah isi array ini   = " << sizeof(nilai) / sizeof(int);
	
	cin.get();
	return 0;
}