#include<stdio.h>
void main()
{
	int n,i, marks[100];
	printf("\n enter number:");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("\n enter marks:");
		scanf("%d",&marks[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\n marks=%d",marks[i]);
	}
}

