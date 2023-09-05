#include<iostream.>
using namespace std;
int main ()
{
	int monthnumber;
	cout<<"enter month number(1-12):";
	cin >> monthnumber;
	switch(monthnumber)
	{
		case1:cout<<"31 days";
		break;
		case2: cout<<" 28 or29 days";
		break;
		case3: cout<<"31 days";
		break;
		case4: cout<<" 30 days";
		break;
		case5: cout<<"31 days";
		break;
		case6: cout<<"30days";
		break;
		case7: cout<<"31 days";
		break;
		case8: cout<<"31 days";
		break;
		case9: cout<<"30 days";
		break;
		case10:cout<<"30 days";
		break;
		case 12: cout<<"31days";
		break;
		default:cout<<"invalid input!!!";
			}
			return 0;
}
