#include <iostream>
using namespace std;

int height(int n) 
{
    int cycle=n,temp=1;;
    if(cycle == 0)
    {
     return 1;    
    }
    else
    {     
    for(int i=1;i<=n;i++)
    {
      
      if(i%2 == 0)
      {
        temp=temp+1;
      }
       else
       {
         temp+=temp;
       }
    }
    return temp;
    }
}
int main() {
    int T;
    cin >> T;
    while (T--) {
        int n;
        cin >> n;
        cout << height(n) << endl;
    }
}
