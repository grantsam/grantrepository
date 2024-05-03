#include <iostream>

using namespace std;

int main()
{
	int a = 1;
	int b = 2;
	bool hasil;

	//and 
	cout << "untuk and" << endl;
	hasil = (a == 1) and (b == 2); //true true
	cout << hasil << endl;
	hasil = (a == 2) and (b == 2); //false true
	cout << hasil << endl;
	hasil = (a == 1) and (b == 1); //true false
	cout << hasil << endl;
	hasil = (a == 2) and (b ==1); //false false
	cout << hasil << endl;

	//or
	cout << "untuk and" << endl;
	hasil = (a == 1) or (b == 2); //true true
	cout << hasil << endl;
	hasil = (a == 2) or (b == 2); //false true
	cout << hasil << endl;
	hasil = (a == 1) or (b == 1); //true false
	cout << hasil << endl;
	hasil = (a == 2) or (b == 1); //false false
	cout << hasil << endl;

	cin.get();
	return 0;
}