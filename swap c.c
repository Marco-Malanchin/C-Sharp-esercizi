#include <stdio.h>
void swap(int*px,int*py)
{
    int temp;
    temp =*px;
    *px = *py;
    *py = temp;
}

int main()
{
int a = 10;
int b = 9;
printf("primo valore %d: secondo valore: %d",a,b);
swap(&a,&b);
printf("\n primo valore %d: secondo valore %d",a,b);
return 0;
}
