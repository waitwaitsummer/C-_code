#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
void main()
{	char ch1, ch2, ch;
	scanf("%c%c", &ch1, &ch2);
	ch = ch1; ch1 = ch2; ch2 = ch;
	printf("ch1=%c,ch2=%c\n", ch1, ch2);
}