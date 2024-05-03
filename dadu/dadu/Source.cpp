#include <iostream>
#include <cstdlib>

using namespace std;

int main()
{
	char lanjut;

	cout << "===== Selamat datang di aplikasi dadu =====" << endl;

	while (true)
	{
		cout << "lempar dadu?< y / n > : ";
		cin >> lanjut;

		if (lanjut == 'y')
		{
			int hasil;
			hasil = 1 + rand() % 6;
			cout << hasil << endl;

			if (hasil == 6)
			{
				for (int i = 1; i <= 3; i++)
				{
					cout << "*";
					cout << " ";
					cout << "*";
					
					cout << endl;
				}
				cout << endl;
			}
		

			else if (hasil == 4)
			{
				for (int i = 1; i <= 2; i++)
				{
					cout << "*";
					cout << " ";
					for (int j = 1; j <= 1; j++)
						//for (int k = 1; k <= 1; k++)
						cout << "*";

					cout << endl;
				}
				cout << endl;
			}


			else if (hasil == 5)
			{
				for (int i = 1; i <= 1; i++)
				{
					cout << "*";
					for (int i = 1; i <= 1; i++)
					{
						cout << " ";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << "*" << endl;
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << " ";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << "*";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << " " << endl;
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << "*";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << " ";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << "*" << endl;
					}
					
					cout << endl;
				}
			}

			else if (hasil == 3)
			{
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
					for (int i = 1; i <= 1; i++)
					{
						cout << " ";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << "*" << endl;
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << " ";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << "*";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << " " << endl;
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << "*";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << " ";
					}
					for (int i = 1; i <= 1; i++)
					{
						cout << " " << endl;
					}

					cout << endl;
				}
			}

			else if (hasil == 2)
			{
			for (int i = 1; i <= 1; i++)
			{
				cout << " ";
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " " << endl;
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << "*";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << "*" << endl;
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " " << endl;
				}

				cout << endl;
			}
			}

			else if (hasil == 1)
			{
			for (int i = 1; i <= 1; i++)
			{
				cout << " ";
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " " << endl;
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << "*";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " " << endl;
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " ";
				}
				for (int i = 1; i <= 1; i++)
				{
					cout << " " << endl;
				}

				cout << endl;
			}
			}
		}

		else if (lanjut == 'n')
		{
			cout << "selesai" << endl;
			break;

		}
		else
		{
			cout << "undefenied" << endl;
		}

	} 



	cin.get();
	return 0;

}