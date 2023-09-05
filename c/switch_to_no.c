# include<stdio.h>
void main()
{
	int num1,num2,result=0;
	char op ;
	printf (" enter2 number");
	scanf("%d%d",&num1,num2);
	printf("enter( +,_,*,)");
	fflush(stdin);
	scanf("%c",&op);
	switch(op)
	case'+':
	result=num1+num2;
	break;
	case'-':
		result=num1-num2;
		break;
		case'*':
			result=num1*num;
			break;
			case'\:
			break;
			default:
				printf(" invalid op");
				break;
				printf ("\n result=%d,result);
	
}
