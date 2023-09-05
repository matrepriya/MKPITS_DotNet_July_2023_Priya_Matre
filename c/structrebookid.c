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
	strcpy ( b1.title,"dotnet");
	strcpy(b1.author,"ashish");
	b1.bookid =123;
	printf(" title=%s",b1.title);
	printf("\nauthor=%s",b1.author);
	printf("\nbookid=%d",b1.bookid);
	
}
