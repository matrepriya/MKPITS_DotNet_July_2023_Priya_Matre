#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string mobileno;
};
class employee: public person
{
	public:
		int empno;
		int salary;
};
class parttimEmployee:public employee
{
	public:
		int noofhours;
};
int main()
{
	employee e1;
	e1.name="priya";
	e1.mobileno="123";
	e1.empno=223;
	e1.salary=12000;
	cout<<"employee details"<<endl;
	cout<<e1.name<<e1.mobileno<<e1.empno<<e1.salary<<endl;
	parttimEmployee p1;
	p1.name="priya";
	p1.mobileno="8805439917";
	p1.empno=263;
	p1.salary=125000;
	p1.noofhours=9;
	cout<<"parttime employee"<<endl;
	cout<<p1.name<<p1.mobileno<<p1.empno<<p1.salary<<p1.noofhours<<endl;
	return 0;
};
