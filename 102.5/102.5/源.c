#define _CRT_SECURE_NO_WARNINGS 1
#include<stdio.h>
int main()
{
	char level;
	float score;
	scanf("%f", &score);
	switch(int(score/10))
	{
	case 10:case 9 :level = 'A'; break;
	case 8:level = 'B'; break;
	case 7:level = 'C'; break;
	case 6:level = 'D'; break;
	default:level='E';
	}
	printf("考试成绩等级为:%c", level);
}