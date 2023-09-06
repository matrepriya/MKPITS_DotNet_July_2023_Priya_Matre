#include<iostream>
using namespace std;
class classA
{
	public:
		void display()
		{
			cout<<"display from classA";
		}
};
class classB
{
	public:
		void display()
		{
			cout<<"display from classB";
		}
};
class classC: public classA, public classB
{
	public:
		void displayc()
		{
		 classA :: display();
		 classB ::display();
		}
};
int main()
{
	classC c1;
	c1.displayc();
}
