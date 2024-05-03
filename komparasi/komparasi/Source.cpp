#include <iostream>

using namespace std;

int main()
{
	int a = 5;
	int b = 6;

	bool hasil1;

	cout << "a = " << a << endl;
	cout << "b = " << b << endl;

	//sebanding
	hasil1 = (a == b);
	cout << "a = b =>";
	if (hasil1 == 1)
	{
		cout << "benar" << endl;
	}
	else if (hasil1 == 0)
	{
		cout << "salah" << endl;

	}

	//tidak sebanding 
	hasil1 = (a != b);
	cout << "a =/ b =>";
	if (hasil1 == 1)
	{
		cout << "benar" << endl;
	}
	else if (hasil1 == 0)
	{
		cout << "salah" << endl;

	}

	//kurang dari
	hasil1 = (a < b);
	cout << "a < b =>";
	if (hasil1 == 1)
	{
		cout << "benar" << endl;
	}
	else if (hasil1 == 0)
	{
		cout << "salah" << endl;

	}

	//lebih dari 
	hasil1 = (a > b);
	cout << "a > b =>";
	if (hasil1 == 1)
	{
		cout << "benar" << endl;
	}
	else if (hasil1 == 0)
	{
		cout << "salah" << endl;

	}

	//kurang dari sama dengan 
	hasil1 = (a <= b);
	cout << "a <= b =>";
	if (hasil1 == 1)
	{
		cout << "benar" << endl;
	}
	else if (hasil1 == 0)
	{
		cout << "salah" << endl;

	}

	//lebih dari sama dengan 
	hasil1 = (a >= b);
	cout << "a >= b =>";
	if (hasil1 == 1)
	{
		cout << "benar" << endl;
	}
	else if (hasil1 == 0)
	{
		cout << "salah" << endl;

	}



	cin.get();
	return 0;

}