// See https://aka.ms/new-console-template for more information
int a = (int)(Convert.ToInt32(Console.ReadLine()));
int b = (int)(Convert.ToInt32(Console.ReadLine()));
int c = (int)(Convert.ToInt32(Console.ReadLine()));
int max = 0;
if (a > b)
{
    max = a;
    //b = a;
}
else
{
    max= b;
}
if (max < c)
{
    max = c;
}
else
{
    max = max;
}
Console.WriteLine("最大数是{0}",max);