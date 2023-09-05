#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
int main()
{
	struct book b1;
	printf("enter title,authorand id\n");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",b1.bookid);
	printf("title=%s",b1.title);
	printf("\nauthor=%s",b1.author);
	printf("\n bookid=%d",b1.bookid);
}
