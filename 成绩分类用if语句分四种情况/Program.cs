// See https://aka.ms/new-console-template for more information
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 90 && a <= 100)
{
    Console.WriteLine("评级为A");
}
else if (a >= 70 && a <= 89)
{
    Console.WriteLine("评级为B");
}
else if (a >= 60 && a <= 69)
{
    Console.WriteLine("评级为C");
}
else
{
    Console.WriteLine("成绩为D");
}