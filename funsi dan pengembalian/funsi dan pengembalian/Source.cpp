#include <iostream>
#include <cmath>

using namespace std;
// fungsi digunakan untuk menyederhanakan suatu proses
//fungsi juga dipakai untuk memanggil suatu proses

int kuadrat(int x,int p,int q) //dengan analogi kuadrat(x) == F(x)
{
	int y;
		y = (x * x) + p + q;
		return (y);
}

void tampilan(int x, int p, int q) // ini adalah void, bisa dipakai saat banyak program yang ingin dibuat
{
	cout << "menggunakan void\n";
	cout << "hasil program adalah : ";
	cout << kuadrat(x, p, q) << endl;

}

int main()
{
	int a, b, c, hasil;

	cout << "===== Selamat datang di kalkulator fungsi" << endl;
	cout << "nilai akan diprogram sesuai struktur berikut => a^2 + b + c " << endl;
	cout << "masukkan nilai a : ";
	cin >> a;
	cout << endl;
	cout << "masukkan nilai b : ";
	cin >> b;
	cout << endl;
	cout << "masukkan nilai c : ";
	cin >> c;
	cout << endl;
	//cout <<"hasil program adalah : " << kuadrat(a, b, c) << endl; //gunakan command ini untuk menjalankan secara normal

	tampilan(a, b, c); // gunakan command ini untuk menjalankan void


	

	cin.get();
	return 0;
}