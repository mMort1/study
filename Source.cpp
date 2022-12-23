#include <iostream>
#include <math.h>

using namespace std;

int trackLength(int m, int n);

int main() {

	setlocale(0, "");
	int m, n;

	cout << "rectangle width ="; 
	cin >> m; //shirina zna4enie

	cout << "rectangle height =";
	cin >> n; //visota zna4enie

	cout << "width " << m << " meter" <<endl << "height " << n << " meter" << endl; //shirina i visota galyavini

	cout << "Length track " << trackLength(m, n) << " meter"; // vivod
}
int trackLength(int m, int n) { //function
	return (m - 1) * (n - 1);
}