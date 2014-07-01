#include<iostream>
using namespce std;

int main()
{
	int test_case;
	int x1,y1,x2,y2;
	cin>>test_case;
	while(test_case--)
	{
	 cin>>x1>>x2>>y1>>y2;
	 cout<<2*x2-x1 <<" "<<2*y2-y1<<endl;
	}

}