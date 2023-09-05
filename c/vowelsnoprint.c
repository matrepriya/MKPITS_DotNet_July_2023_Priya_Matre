#include<stdio.h>
#include<string.h>
void main()
{
	int cnt=0;
	char name[10];
	char*ptr;
	printf(" enter name");
	gets(name);
	ptr=name;
	while(*ptr!='\o')
	{
		if(*ptr=='a'|| *ptr=='e'|| *ptr=='i'||*ptr=='o'|| *ptr=='u');
		{
			cnt = cnt+1;
		}
		ptr++;
		}
		printf("no name of vowels in o string =%d",cnt);
	}

