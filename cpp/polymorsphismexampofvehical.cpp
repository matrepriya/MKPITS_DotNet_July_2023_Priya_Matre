#include<iostream>
using namespace std;
class vehicle
{
	public:
		virtual void start()
		{
			cout<<"engine is start"<<endl;
		}
		virtual void stop()
		{
			cout<<"engine is stop"<<endl;
		}
};
class car:public vehicle
{
	void start()
	{
		cout<<"car is start"<<endl;
	}
	void stop()
	{
		cout<<"car is stop"<<endl;
	}
};
class motorcycle:public vehicle
{
	void start()
	{
		cout<<"motorcycle is start"<<endl;
	}
	void stop()
	{
		cout<<"motorcycle is stop"<<endl;
	}
};
class truck:public vehicle
{
	void start()
	{
		cout<<"truck is start"<<endl;
	}
	void stop()
	{
		cout<<"truck is stop"<<endl;
	}
};
int main()
{
    vehicle *v;
	car c;
	motorcycle m;
	truck t;
	v=&c;
	v->start();
	v->stop();
	v=&m;
	v->start();
	v->stop(); 
	v=&t;
	v->start();
	v->stop();
	return 0;
}

