#include <iostream>
using namespace std;

void kuadrat(int *);
void fungsi(int*);

int main()
{
	int a = 5; //int
	cout << " +++++ MATERI FUNGSI DENGAN POINTER +++++\n\n" << endl;
	cout << " alamat a = " << &a << endl;
	cout << " nilai  a = "<< a << "\n" << endl; //cout a

	kuadrat(&a); //update a => kuadrat(&a);
	cout << " alamat a = " << &a << endl;
	cout << " nilai  a = " << a <<"\n"<< endl; //new a
	
	

	
	cin.get();
	return 0;
}

void kuadrat(int *valPtr)
{
	*valPtr = (*valPtr) * (*valPtr);
}
