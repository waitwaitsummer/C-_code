// See https://aka.ms/new-console-template for more information
Console.WriteLine("请输入两个大写字母");
char one = char.Parse(Console.ReadLine());
char two = char.Parse(Console.ReadLine());
if (one > two)
{
    Console.WriteLine("{0}>{1}", one, two);
}
else if (one < two)
{
    Console.WriteLine("{0}<{1}",one, two);
}