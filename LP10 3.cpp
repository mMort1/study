#include<iostream>
#include<math.h>
#define PI 3.14159265  

using namespace std;


int main()
{
	int x;
	double v1 = 0,v2=0, cotan; 


	cout << "Value1 = ";
	cin >> v1;

	cout << "z1= " << (sin(4 * v1)) / (1 + (cos(4 * v1))) * (cos(2 * v1)) / (1 + cos(2 * v1))<<endl;

	cout << "Value2 = ";
	cin >> v2;
	
	cout << "Value X = ";
	cin >> x;

	cotan = pow(1. / tan((double)x), 2);
	cout << "z2= " << (cotan * (3 / 2) * PI - v2);
}
