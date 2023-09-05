#include<stdio.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void printbook( struct book b1);
int main()
{
	struct book b1;
	printf (" enter title,author and id");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%s",b1.bookid);
	scanf("%d",&b1.bookid);
}
void printbook( struct book b1)
{
	printf(" title=%s",b1.title);
	printf("\n author=%s",b1.author);
	printf("\n bookid=%d",b1.bookid);
}
