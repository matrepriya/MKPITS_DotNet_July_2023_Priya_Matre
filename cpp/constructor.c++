#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
		employee(int empno,string empname)
		{
			this->empno=empno;
			this->empname=empname;
		}
		void display() 
		{
			cout<<"empno"<<"empno"<<endl;
			cout<<"empname"<<empname<<endl;
		}
		
};
int main()
{
	int eno;
	string en;
	employee emp1( 11,"priya");
	emp1.display ();
	return 0;
}
