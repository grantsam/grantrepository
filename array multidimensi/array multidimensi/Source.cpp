#include <iostream>
using namespace std;

void printarray(int* ptrarray, int baris, int kolom)
{
	int index = 0;
	for (int i = 0; i < baris; i++)
	{
		for (int j = 0; j < kolom; j++)
		{
			cout << *(ptrarray + index) << " ";
			index++;
		}
		cout << endl;
	}
}

int main()
{
	int arrayid[2][2] = { 1,2,3,4 };
	printarray(*arrayid, 2, 2);

	cin.get();
	return 0;
}