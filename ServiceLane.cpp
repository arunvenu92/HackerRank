#include<iostream>
using namespace std;
#define MAX 100000
int main()
{
	int number,test_case,lane[MAX];
	int from,to;
    cin>>number;
	cin>>test_case;
	 for(int i=0;i<number;i++)
	 {
		 cin>>lane[i];
	 }
	
	while(test_case--)
	{
	 int minimum_value;
	 cin>>from>>to;
	 minimum_value=lane[from];
	 while(from<=to)
	 {
		if(lane[from] < minimum_value)
		 {
			 minimum_value=lane[from];
		 }
		from++;
	 }
	 cout<<minimum_value;
	}
}