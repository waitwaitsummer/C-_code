#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
int main()
{
	int day = 0;
	while (day < 30000)
	{
		printf("¼ÌÐø³Áµí%d\n",day);
		day++;
	}
	if (day == 30000)
	{
		printf("³É¹¦\n");
	}
	return 0;
}