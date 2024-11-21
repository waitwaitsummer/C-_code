// See https://aka.ms/new-console-template for more information
Console.WriteLine("输入一个非0整数");
int x = int.Parse(Console.ReadLine());
if (x > 0)
{
    Console.Write("是正数，绝对值是");
    Console.WriteLine(x);
}
else if (x == 0)
{
    Console.WriteLine("输入数字等于0请重新输入一个非0整数");
}
else
{
    Console.WriteLine("是负数，绝对值是");
    Console.WriteLine(-x);
}
