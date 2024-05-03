#include <iostream>
#include <array>

using namespace std;

int main()
{
	array<int, 10>nilai;
	for (int i = 0; i < nilai.size(); i++)
	{
		cout << " mahasiswa dengan nilai ";
		if (i == 0)
		{
			cout << "0 - 9 : ";
		}
		else if (i == 9)
		{
			cout << " 100 : ";
		}
		else
		{
			cout << i * 10 << " - " << i * 10 + 9 << " : ";
		}
		cin >> nilai[i];

	}

	cout << endl;
	for (int i = 0; i < nilai.size(); i++)
	{
		    cout << " mahasiswa dengan nilai ";
			if (i == 0)
			{
				cout << "0 - 9 : ";
			}
			else if (i == 9)
			{
				cout << " 100 : ";
			}
			else
			{
				cout << i * 10 << " - " << i * 10 + 9 << " : ";
			}
			for (int i = 0; i <= nilai[i]-1; i++)
			{
				cout << "*";
			}
			cout << endl;
	}

	cin.get();
	return 0;
}