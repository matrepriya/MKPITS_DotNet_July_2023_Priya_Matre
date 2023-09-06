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
			display();
		}
};
int main()
{
	classc c1;
	c1.display();
}
