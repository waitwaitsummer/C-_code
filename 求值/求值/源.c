#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
void main()
{
	char ch1, ch2;
	int n1, n2;
	ch1 = getchar();
	ch2 = getchar();
	n1 = ch1 - '0';
	n2 = n1 * 10 + (ch2 - '0');
	printf("n1=%d,n2=%d.\n", n1, n2);
}
//n1=1,n2=12