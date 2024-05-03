#include <iostream>
using namespace std;

int x = 10; //global scope

int Global_scope()
{
	return x;
}

int Local_scope()
{
	x = 2; //local scope
	return x;
}

int main()
{
	int x = 5; //main scope

	cout << "main scope : " << x << endl;
	cout << "global scope : " << Global_scope() << endl;
	cout << "local scope : " << Local_scope() << endl;
	{
		int x = 3; //block scope
		cout << "block scope : " << x << endl;
	}

	cin.get();
	return 0;
}