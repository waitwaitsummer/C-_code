// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
}
else if (a == b)
{
    if (b % 2 == 0)
    {
        Console.WriteLine("b");
    }
    else
    { Console.WriteLine("没有偶数"); }
}
else
{
    max = b;
    min = a;
}
if (min % 2 == 1)
{
    min++;
}
else if (max % 2 == 0)
{ 
    max+=2;
}
while (min < max)
{
        Console.WriteLine(min);
        min = min + 2;
    
}