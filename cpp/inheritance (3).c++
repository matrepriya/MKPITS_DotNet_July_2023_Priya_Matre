#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		string city;
};
class student : public person
{
	public:
		int rno;
		int marks;
};
int main()
{
	student s1;
	s1.name="priya";
	s1.city="nagpur";
	s1.rno= 123;
	s1.marks=980;
	cout<<s1.name<<s1.city<<s1.rno<<s1.marks<<endl;
	return 0;
}
	 
		

