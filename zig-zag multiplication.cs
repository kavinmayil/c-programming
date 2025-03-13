#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main(){
    int n,m;
    scanf("%d",&n);
    scanf("%d",&m);
    int a[n][m];
    for(int i=0;i<n;i++){
        for(int j=0;j<m;j++){
        scanf("%d",&a[i][j]);
        }
    }int sum=0;
    for(int i=0;i<n;i++){
        for(int j=0;j<m;j++){
            if(i==0 || i==j || i==m-1){
                sum=sum+a[i][j];
            }
        }
    }printf("Sum of Zig-Zag pattern is %d",sum);
    return 0;
}
