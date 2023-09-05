# include <stdio.h>
int main()
{
   int num;
  
  printf(" enter any no to check even or odd :");
    scanf (" %d",& num);
    switch( num % 2)
{

case 0:
	 printf("number is even");
	 break;	
case 1:
      printf ("number is odd");
      break;
      default:
     
	 break;
}

     return 0;
}

