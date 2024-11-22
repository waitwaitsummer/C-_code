// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("请输入三个整数");
double a=double.Parse(Console.ReadLine());
double b=double.Parse(Console.ReadLine());
double c=double.Parse(Console.ReadLine());
Console.WriteLine("最大数的平方是");
if (a >= b)
{
    if (a >= c)
    {
        Console.WriteLine(a * a);
    }
}
else if (b >= c)
{
    if (b >= a)
    {
        Console.WriteLine(b * b);
    }
}
else if (c >= a)
{
    if (c >= b)
    { Console.WriteLine(c * b); }
}
