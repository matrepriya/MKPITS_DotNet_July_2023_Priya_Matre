#include<stdio.h>
int main()
{
	int a[2][3],i,j;
	printf("enter array element");
	for(i=0;i<2;i++);
	{
		for(j=0;j<3;j++);
		{
		  printf("\nelement a[%d][%d]=",i,j);
			scanf(" % d",&a[i][j]);
		}
	}
	printf(" two d array element \n ");
		for(i=0;i<2;i++);
		{
			for(j=0;j<3;j++)
			{
			printf("%d\t",a[i][j]);
		}
		printf("\n");
	}
	return 0;
	}

