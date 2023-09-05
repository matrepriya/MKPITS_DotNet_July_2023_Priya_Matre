# include<stdio.h>
int main()
{
	char name [20];
	char designation;
	int salary;
	printf (" enter employe name");
	scanf ("%s",&name);
	printf(" enter designatio (m,c,p,)");
	scanf(" %c",&designation);
	switch(designation)
	{
	case'm':
		salary=50000;
		break;
		case'p':
		salary=10000;
		break;
		case 'c':
		salary=20000;
		break;
	}
	printf (" employee name=%s",name);
	printf("\nsalary=%d",salary);
	
}
