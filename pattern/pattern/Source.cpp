#include <iostream>

using namespace std;

int main()
{
	cout << "=====Materi Segitiga Siku=====" << endl;
	cout << endl;

	int n;
	cout << "masukkan nilai : ";
	cin >> n;
	cout << endl;
	cout << endl;


	cout << "pattern1" << endl;
	for (int i = 1; i <= n; i++)
	{
		for(int j=1; j<=i; j++)
			cout << "*";
		cout << endl;
	}
	cout << endl;


	cout << "pattern2" << endl;
	for (int i = 1; i <= n; i++) 
	{
		for (int j = i; j <= n; j++)
		{
			cout << "*";
		}
		cout << endl;

	}
	cout << endl;


	cout << "pattern3" << endl;
	for (int i = 1; i <= n; i ++ )
	{
		for (int j=1; j<=i;j++)
		{
			cout << " ";
		}
		for (int k = n; k >= i; k--)
		{
			cout << "*";
		}
		cout << endl;
	}
	cout << endl;

	cout << "pattern4" << endl;
	for (int i = 1; i <= n; i++)

	{
		for(int j = i; j<=n ;j++)
		{
			cout << " ";
		}
		for (int k =1 ; k <= i; k++)
		{
			cout << "*";
		}
		
		
		cout << endl;
	}
	cout << endl;

	cout << "pattern5" << endl;
	for (int i = 1; i <= n; i++)

	{
		for (int j = i; j <= n; j++)
		{
			cout << " ";
		}
		for (int k = 1; k <= 2*i-1; k++)
		{
			cout << "*";
		}


		cout << endl;
	}
	cout << endl;

	cout << "pattern6" << endl;
	for (int i = 1; i <= n; i++)
	{
		for (int j = 1; j <= i; j++)
		{
			cout << " ";
		}
		for (int k = n; k >= 2*i-5; k--)
		{
			cout << "*";
		}
		cout << endl;
	}
	cout << endl;

	cout << "pattern7" << endl;
	for (int i = 1; i <= n; i++)

	{
		for (int j = i; j <= n; j++)
		{
			cout << " ";
		}
		for (int k = 1; k <= 2 * i - 1; k++)
		{
			cout << "*";
		}


		cout << endl;
	}
	for (int i = 1; i <= n; i++)
	{
		for (int j = 1; j <= i+1; j++)
		{
			cout << " ";
		}
		for (int k = n; k >= 2 * i - 3; k--)
		{
			cout << "*";
		}
		cout << endl;
	}
	cout << endl;



	


	cin.get();
	return 0;
}
