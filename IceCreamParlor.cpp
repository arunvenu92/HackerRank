#include<iostream>
using namespace std;
#define value 10000

int main()
{
int test_case,dollar,flavour,k,j,flag=0;
int flavour_array[value];
cin>>test_case;

while(test_case >  0)
{
cin>>dollar;
cin>>flavour;
for(int i=1;i<=flavour;i++)
{
cin>>flavour_array[i];
}

for(k=1;k<=flavour;k++)
{
for(j=1;j<=flavour;j++)
{
if(k!=j && flag!=1)
{
if((dollar-(flavour_array[k] + flavour_array[j]))==0)
{
cout<< k << " "<<j<<endl;
flag=1;
}
else
{
continue;
}
}
else
{
continue;
}
}
}
test_case--;
flag=0;
}

}
