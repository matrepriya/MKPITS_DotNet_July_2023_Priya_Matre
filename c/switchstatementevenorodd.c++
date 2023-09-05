#include<iostream.>
using namespace std ;
int main()
{
	int num;
	cout<<"enter the even number to check even or odd:";
	cin>>num;
	switch (num%2)
	{
		case 0:cout <<"number is evev";
		break;
		case 1:cout<<"numberis odd";
		break;
	}
	return 0;
}
