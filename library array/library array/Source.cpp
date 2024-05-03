#include <iostream>
#include <array>
using namespace std;

int main()
{
	//membuat array dengan library 
	// array<int ,jumlah array> nama array;

	array<int, 5>nilai;
	for (int i = 0; i <= 4; i++)
	{
		nilai[i] = i;
		cout << "nilai[" << i << "]" << " = " << nilai[i];
		cout << " alamat i = " << &nilai[i] << endl;
	}
	cout << endl;
	cout << "ukuran array : " << nilai.size()<<endl;
	cout << "nilai awal  : ";
	nilai.begin(); //nilai awal
	cout << endl;
	cout << "nilai akhri : ";
	nilai.end(); //nilai alhri
	cout << endl;
	cout << "nilai ke 3 : ";
	nilai.at(3);
	cout << endl;



	cin.get();
	return 0;
}