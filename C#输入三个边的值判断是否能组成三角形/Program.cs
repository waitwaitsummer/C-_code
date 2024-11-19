// See https://aka.ms/new-console-template for more information
Console.WriteLine("请输入三角形三边边长");
Console.WriteLine("第一条边");
double a = (double)(Convert.ToDouble(Console.ReadLine()));
Console.WriteLine("第二条边");
double b = (double)(Convert.ToDouble(Console.ReadLine()));
Console.WriteLine("第三条边");
double c = (double)(Convert.ToDouble(Console.ReadLine()));
if (a + b > c )
{
    if (a == b && a == c)
    {
        Console.WriteLine("可以组成等边三角形");
    }
    else if (a == b || a == c)
    {
        Console.WriteLine("可以组成等腰三角形");
    }
    else
    {
        Console.WriteLine("可以组成三角形");
    }
    
}
else
{
    Console.WriteLine("不可以组成三角形,请重新输入");
}