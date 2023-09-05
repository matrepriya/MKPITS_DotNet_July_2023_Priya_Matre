#include<stdio.h>
#include<conio.h>
int main()
{
	int a[100],b[200],i,j,n,c=0;
	printf("enter size of the array:");
	scanf("%d",&n);
	printf("enter element in array:");
	for(i=0;i<n;i++)
	{
		scanf("%d",&a[i]);
	}
	printf("unique number in the array:\n");
		for(i=0;i<n;i++)
		{
			c=0;
			if(a[i]!=-1)
			{
				for(j=i+1;j<n;j++)
				{
					if(a[i]==a[j])
					{
						c++;
						a[j]==1;
					}
			    	}
			    	b[j]=c;
			    }
			    }
			    for(i=0;i<n;i++)
			    {
			    	if(b[i]==1)
			    	printf("%d\n",a[i]);
			    	return 0;
			    }
				}
		     
		 
			    
			
			
		    
		
	
	
			
			    
				
	
					
				
			
		


	

