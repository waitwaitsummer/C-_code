// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("请输入一个浮点数：");
double a = double.Parse(Console.ReadLine());
double b = (int)(a * 100 + 0.5) / 100.0;
Console.WriteLine(b);