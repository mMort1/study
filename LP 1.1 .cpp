#include<iostream>
#include<math.h>

using namespace std;


int main()
{
	// 1
	setlocale(LC_ALL, "rus");
	setlocale(0, ".1251");
	
	double b1 = 0, b2 = 0, b3 = 0;
	cout << "первое знач = ";
	cin >> b1;
	cout << "второе знач = ";
	cin >> b2;
	cout << "основа = ";
	cin >> b3;

	cout << "\n""периметр = " << b1 + b2 + 2 * b3 << endl;
	cout << "площадь = " << ((b1 + b2) / 2) * sqrt(pow(abs(b1 - b2) / 2, 2) + pow(b3, 2)) << endl;

	// 2
	double m1 = 0, m2 = 0, m3 = 0, p1 = 8.50, p2 = 2.40, p3 = 4.10;
	cout << "маса масла: ";
	cin >> m1;

	cout << "маса сметани: ";
	cin >> m2;

	cout << "маса вершкiв: ";
	cin >> m3;
	

	cout << "Цiна за " << m1 << "кг масла = " << m1 * p1 << endl;
	
	cout << "Цiна за " << m2 << "кг сметани = " << m2 * p2 << endl;

	cout << "Цiна за " << m3 << "кг вершкiв = " << m3 * p3 << endl;

}