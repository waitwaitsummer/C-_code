// See https://aka.ms/new-console-template for more information
int c = int.Parse(Console.ReadLine());
int d1, d2, d3;
Console.WriteLine("请输入一个三位数");
d1 = c / 100;
d2 = c / 10 % 10;
d3 = c % 10;
Console.WriteLine("个位数{0}\n十位数{1}\n百位数{2}", d3, d2, d1);
