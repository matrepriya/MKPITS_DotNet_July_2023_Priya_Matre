#include<iostream>
using namespace std;
class Ability
{
	protected:
		   string AbilityName;
		 public:
			void getName(string an)
			{
				AbilityName =an;
			}
};
class Equipment
{
	protected:
		string equipmentitem;
		public:
			void getei( string e1)
			{
				equipmentitem=e1;
			}
};
class character: public Ability, public Equipment
{
	private: 
	string characterName;
	public:
		void getcharaName ( string cn)
		{
			characterName= cn;
		}
		void display ()
		{
			cout<<"characterName"<<characterName<<endl;
			cout<<"Ability"<<AbilityName<<endl;
		    cout<<"equipmentitem"<<equipmentitem<<endl;
		}
	};
	int main()
	{
		character c1;
		c1.getName ("attack");
		c1.getei("gan");
		c1.getcharaName("alien");
		c1.display();
		return 0;
		
	}
