#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		virtual void deposit(int amt)
		{
			cout<<"hello from account deposite"<<endl;
		}
};
class saving :public Account
{
	public:
		void deposit(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
			cout<<"bal with int is"<<bal<<endl;
			}
};
class current:public Account
{
	public:
		void deposite( int amt)
		{
			bal=bal+amt;
			cout<<"bal with int"<<bal<<endl;
		}
};
int main()
{
	Account*A;
	saving s;
	current c;
	A=&s;
	A->actno=123;
	A->bal=1000;
	A->deposit(500);
	A=&c;
	A->actno=233;
	A->bal=400;
	A->deposit(500);
	return 0;
}
