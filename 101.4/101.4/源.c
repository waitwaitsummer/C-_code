#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
void main()
{
	char ch;
	ch = getchar();
	if (ch >= 'A' && ch <= 'Z' - 6)
		ch = ch + 6;
	else if (ch > 'Z' - 6)
		ch = ch + 5 - 'Z' + 'A';
	putchar(ch);
}
