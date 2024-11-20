// See https://aka.ms/new-console-template for more information
int e = int.Parse(Console.ReadLine());
int f = 0;
int g = 0;
int l = 0;
Console.WriteLine("请输入一个整数");
while (e > 0)
{
    f = e % 10;
    g = g * 10 + f;
    e = e / 10;
    l++;
}
Console.WriteLine("倒序输出是：{0}", g);
Console.WriteLine("这是一个{0}位数", l);
