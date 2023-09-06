#include<iostream>
using namespace std;
 class employee
 {
 	public:
 		string name;
 		string designation;
 		string address;
 };
 class details :public employee
 {
 	public:
 		int salary;
 		int empno;
 };
 int main()
 {
 	details e1;
 	e1.name="priya\n";
 	e1.address="murtizapur\n";
 	e1.designation="police\n";
 	e1.salary=200;
 	cout<<e1.name<<e1.designation<<e1.address<<e1.salary<<endl;
 	return 0;
 }
 
