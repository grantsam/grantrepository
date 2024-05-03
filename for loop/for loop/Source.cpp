#include <iostream>

using namespace std;

int main()
{
	cout << "===== selamat datang di materi for loop =====" << endl;
	cout << "LOOP1\n";
	for (int i = 1; i <= 5; i++)
	{
		cout << i << endl;
		if (i >= 5)
		{
			cout << " =====program selesai=====\n";
			break;
		}
	}
	cout << "LOOP2\n";
	for (int i = -1; i >= -5; i--)
	{
		cout << i << endl;
		if (i <= -5)
		{
			cout << " =====program selesai=====\n";
			break;
		}
	}
	cout << "LOOP3\n";
	for (int i = 1; i <= 10; i += 2)
	{
		cout << i << endl;
		if (i >= 9)
		{
			cout << " =====program selesai=====\n";
			break;
		}
	}
	cout << "LOOP4\n";
	int botol = 0;
	for (int i = 1; botol += i, i <= 10; i++)
	{
		cout << i << "||" << botol << endl;
		if (i >= 10)
		{
			cout << " =====program selesai=====\n";
			break;
		}
	}
	cin.get();
	return 0;
}