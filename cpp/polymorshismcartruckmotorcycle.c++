#include<iostream>
using namespace std;
class vehicle
{
	public:
	virtual void satrt()
	{
	cout<<"engine is start"<<endl;
}
virtual void stop()
{
cout<<"engine is stop"<<endl;
}
};
virtual void start()
{
cout<<"engine is start"<<endl;
}
virtual void stop()
{
cout<<"engine is stop"<<endl;
}
};
class motorcycle:public vehicle
	virtual void start()
		{
	   cout<<"motorcycle is start"<<endl;
		}
				virtual	void stop()
					{
						cout<<"motorcycle is stop"<<endl;
					}
};
					class Truck: public vehicle
					{
						public:
							void start()
							{
								cout<<"Truck is start"<<endl;
							}
							void stop()
							{
								cout<<"Truck is stop"<<endl;
							}
		};
		class car: public vehicle
		{
			void star()
			{
				cout<<" car is start"<<endl;
			}
			void stop()
			{
				cout<<"car is stop"<<endl;
			}
		};
		int main()
		{
			vehicle*v;
			car c;
			motorcycle m;
			Truck t;
			v=&c;
			v->start();
			v-> stop();
			v=&m;
			v->start();
			v->stop();
			v=&t;
			v->start();
			v->stop();
			return 0;
			}
		
		

