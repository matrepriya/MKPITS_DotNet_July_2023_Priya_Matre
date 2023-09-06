#include<iostream>
using namespace std;
class person
{
	public:
	string name;
	int mobno;
	void getpersondata(string name,int mobno)
	{
		this->name=name;
		this->mobno=mobno;
	}
};
class employee :public person
{
	public:
		int empno;
		int sal;
		void getempdata(int empno,int sal)
		{
			this->empno=empno;
			this->sal=sal;
		}
		void displaydata()
		{
			cout<<"name"<<name<<endl;
			cout<<"mobno"<<mobno<<endl;
			cout<<"empno"<<empno<<endl;
			cout<<"sal"<<sal<<endl;
		}
};
int main()

{
	employee emp;
	cout<<"enter employee details";
	cin>>emp.name>>emp.empno>>emp.mobno>>emp.sal;
	emp.getpersondata(emp.name,emp.mobno);
	emp.getempdata(emp.empno,emp.sal);
	emp.displaydata();
	return 0;
}
	

