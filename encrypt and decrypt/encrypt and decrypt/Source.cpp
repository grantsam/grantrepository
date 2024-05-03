#include <iostream>
using namespace std;


int main()
{
	int x;
	char str[75];
	cout << "plaintext : ";
	cin >> str;
	cout << " key : ";
	cin >> x;
	cout << "hasil dekripsi : ";
	

	for (int i = 0; i < 5 && str[i] != '\0'; i++)
	{
		str[i] = str[i] - x;
		cout << str << endl;
		break;
	}
}

