#define _CRT_SECURE_NO_WARNINGS 1
#include <stdio.h>
int main()
{
	int day = 0;
	while (day < 30000)
	{
		printf("��������%d\n",day);
		day++;
	}
	if (day == 30000)
	{
		printf("�ɹ�\n");
	}
	return 0;
}