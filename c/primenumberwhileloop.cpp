#include<stdio.h>
int main()
{
	int num;
	int counter=2;
	int rem=0;
	printf("enter a num :");
	scanf("%d",&num);
	while(counter<num)
	{
		rem=num%counter;
	if(rem==0)
	{
		
		printf("It is not a prime no");
		break;
	}
	counter=counter+1;
    
    if( num==counter)
    {
       printf( " it is a prime number");
	}
    }
	
}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

