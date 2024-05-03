# include <iostream>
#include <array>
#include <algorithm>

using namespace std;
const size_t arraysize = 10;

void printangka(array <int, arraysize>& angka)
{
	cout << "array : ";
		for (int &a : angka)
		{
			cout << a << " ";
		}
}

int main() 
{
	array <int, arraysize>angka{ 9, 8, 7, 6, 5, 4, 3, 2, 1 };
	printangka(angka);
	cout << endl;
	sort(angka.begin(), angka.end());
	printangka(angka);



	cin.get();
	return 0;

}