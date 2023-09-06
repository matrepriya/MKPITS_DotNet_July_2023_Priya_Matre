#include<iostream>
using namespace std;
class Animals
{
	public:
		virtual void sound()
		{
			cout<<"Animal sound "<<endl;
		}
};
class Dog: public Animals
{
	public:
		void sound()
		{
			cout<<"Dog sound is Woof-Woof"<<endl;
		}
};
class Cat :public Animals
{
	public:
		void sound()
		{
			cout<<"cat sound is meow-meow"<<endl;
		}
};
class cow:public Animals
{
	public:
		void sound()
		{
			cout<<"cow sound is maa-maa"<<endl;
		}
};
int main()
{
	Animals* A;
	Animals a1;
	Dog d;
	Cat c;
	cow c1;
	A=& a1;
	A->sound();
	A= &d;
	A-> sound();
	A=& c;
	A=& c1;
	A->sound();
	return 0;
}
