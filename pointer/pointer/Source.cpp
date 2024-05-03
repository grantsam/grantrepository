#include <iostream>
using namespace std;

int main()
{
	int a = 1; //nilai int
	int *ptra =  &a; //*ptra digunakan sebagai fungsi alamat dari int a // '*' digunakan untuk menginisiasi menjadi alamat 
	                 // &a untuk memanggil alamat dari int a // '&' digunakan untuk memanggil alamat 


	cout << "+++++ POINTER +++++\n\n\n";
	cout << "nilai objek : " << a << endl; //memanggil nilai a

	cout << "alamat objek : " << &a << endl; //memanggil alamat a


	cout << "nilai pointer : " << *ptra << endl; //memanggil nilai dari (alamat ptra / alamat a)

	a = 5; //update nilai (alamat ptra / alamat a)

	cout << "nilai pointer setelah update : " << *ptra << endl; // memanggil nilai dari (alamat ptra/ alamat a) setelah a  diupdate 
	cout << "\n\n\n";
	cout << "+++++REFERENCE+++++\n\n\n" << endl;

	int &b = a; //referencing

	cout << "nilai objek ke - 2 : " << b << endl; //nilai objek b akan nyantol ke a
	b = 3; //update nilai b
	cout << "nilai objek ke  -2 : " << a; //nilai a akan nyantol ke si b karena referencing 

	
	cin.get();
	return 0;

}