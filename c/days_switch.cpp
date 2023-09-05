#include<stdio.h>
void main()
{
	char month[10];
	printf(" enter month", month);
	scanf(" /s",&.month);
	switch( month)
	{
	case'jan':
	case'march':
	case 'may':
	case'june':
	case'august':
	printf(" 31 days");	
	break;
	case'april':
	case'june':
	case'sep':
	case'nov':
	
	printf(" 30 days");
	default:
	printf(" invalid month");
	break;
		
 	}
	
}
