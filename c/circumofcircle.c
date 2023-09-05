#include<stdio.h>
void calculate (int r,float*a,float*c)
{
	*a=3.14f*r*r;
	*c=2*3.14f*r;
}
  void main ()
  {
  	int radius;
  	float area, circu;
  	printf(" enter radius");
  	scanf("%d"&radius);
  	calulate(&radius,&area,&circ);
  	printf("\n circ=%f",area);
  	printf("\n circ=%f",circ);
  	
  }
  
