#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
#include <math.h>
#define pie 3.1415926
int main()
{
	double x, s, b;
	printf("input number:\n");
	scanf("%if", &x);
	b = x * pie / 180;
	s = sin(b);
	printf("sin of %lf is %if\n ", x, s);
	return 0;
}