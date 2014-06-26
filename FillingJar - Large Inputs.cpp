#include<iostream>
using namespace std;

int main()
{
	long long int no_jars,test_case,temp_res=0,a,b,k;
	cin>>no_jars;
	cin>>test_case;
	while (test_case > 0)
	{
		cin>> a >> b >> k;
    	temp_res+=(b-a+1)*k;
		cout<<temp_res;
		test_case--;
	}
	cout<<temp_res<<endl;
	long long int final_res=temp_res/no_jars;
	cout<<final_res;
}
