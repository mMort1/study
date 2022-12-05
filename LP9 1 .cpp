#include<iostream>
#include<math.h>

using namespace std;


int main()
{
	// 1
	setlocale(LC_ALL, "rus");
	setlocale(0, ".1251");
	
	double b1 = 0, b2 = 0, b3 = 0;
	cout << "ïåðâîå çíà÷ = ";
	cin >> b1;
	cout << "âòîðîå çíà÷ = ";
	cin >> b2;
	cout << "îñíîâà = ";
	cin >> b3;

	cout << "\n""ïåðèìåòð = " << b1 + b2 + 2 * b3 << endl;
	cout << "ïëîùàäü = " << ((b1 + b2) / 2) * sqrt(pow(abs(b1 - b2) / 2, 2) + pow(b3, 2)) << endl;

	// 2
	double m1 = 0, m2 = 0, m3 = 0, p1 = 8.50, p2 = 2.40, p3 = 4.10;
	cout << "ìàñà ìàñëà: ";
	cin >> m1;

	cout << "ìàñà ñìåòàíè: ";
	cin >> m2;

	cout << "ìàñà âåðøêiâ: ";
	cin >> m3;
	

	cout << "Öiíà çà " << m1 << "êã ìàñëà = " << m1 * p1 << endl;
	
	cout << "Öiíà çà " << m2 << "êã ñìåòàíè = " << m2 * p2 << endl;

	cout << "Öiíà çà " << m3 << "êã âåðøêiâ = " << m3 * p3 << endl;

}
