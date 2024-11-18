// See https://aka.ms/new-console-template for more information

double x = (double)(Convert.ToDouble(Console.ReadLine()));
double y = (double)(Convert.ToDouble(Console.ReadLine()));
if (x > 0 && y > 0)
{
    Console.WriteLine("这个坐标位于第一象限");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("这个坐标位于第三象限");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("这个坐标位于第四象限");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("这个坐标位于第二象限");
}
else if (x == 0 && y != 0)
{
    Console.WriteLine("这个坐标在x轴上");
}
else if (x != 0 && y == 0)
{
    Console.WriteLine("这个坐标在y轴上");
}
else
{
    Console.WriteLine("这个坐标是原点");
}