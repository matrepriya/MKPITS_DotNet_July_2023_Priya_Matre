#include<iostream>
using namespace std;
class sample1
{
	public:
		void display()
		{
			cout<<"display super class function\n";
			
        }
};
class simple2: public simple1
 {
	public:
		void show()
		{
			cout<<"show sub class function";
		}
};
int main();
{
	simple2 ob;
	ob.display();
	ob.show();
	cout<<ob.display<<ob.show;
	return 0;
}

