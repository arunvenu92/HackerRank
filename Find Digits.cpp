#include<iostream>
#include<math.h>
using namespace std;

int main()
{
long long int number,permenent=0;
int test_case,counter=0;
cin>>test_case;
while(test_case--)
{
  int temp=0;
  cin>>number;
  permenent=number;
   while(number != 0)
   {
	   temp = number % 10;
	   if(temp == 0)
	   {
	     number/=10;
		 continue;
	   }
	   if(permenent % temp == 0)
        {
		 counter++;
	    }
	number/=10;
   }


  cout<<counter;
  getchar();
  counter=0;
}

}