#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		virtual void deposite (int amt)=0;
};
class saving:public Account
{
	public:
		void deposite(int amt)
		{
			int interest =500;
			bal=bal+amt+interest;
			cout<<"bal with int is :"<<bal<<endl;
		}
	};
			class current: public Account
			{
				public:
					void deposite(int amt)
					{
						bal=bal+amt;
						cout<<"bal with int :"<<bal<<endl;
					}
			};
			int main()
			{
				Account*A;
				saving s;
				 current c;
				 A=&s;
				 A->actno=123;
				 A->bal=2000;
				 A->deposite(100);
				 A=&c;
				 A->actno=333;
				 A->bal=100;
				 A->deposite(500);
				 return 0;
			}
		

