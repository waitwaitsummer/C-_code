// See https://aka.ms/new-console-template for more information
Console.WriteLine("输入一个年份，判断是不是闰年");
int Year=int.Parse(Console.ReadLine());
if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
{
    Console.WriteLine("是闰年");
}
else
{
    Console.WriteLine("不是闰年");
}