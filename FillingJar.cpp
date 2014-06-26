#include<iostream>
using namespace std;
#define N 10000000

static long long int jars[N]={0};

int main()
{
	long long int no_jars,test_case,temp_res=0,a,b,k;
	cin>>no_jars;
	cin>>test_case;
	while (test_case--)
	{
		cin>> a >> b >> k;

		for(long long int i=a-1;i<=b-1;i++)
		{
			jars[i]+=k;
		}
		for(int i=0;i<no_jars;i++) 
		{
			cout<<jars[i];
		}
	}
	
	for(long long int i=0;i<=no_jars-1;i++)
	{
		temp_res+=jars[i];
	}
	cout<<temp_res<<endl;
	long long int final_res=temp_res/no_jars;
	cout<<final_res;
	getchar();
	getchar();

}