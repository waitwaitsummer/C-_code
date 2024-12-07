// See https://aka.ms/new-console-template for more information
int a = 10000;
int b = 0;
while (a < 100000)
{
    a = (int)(a * 1.25f);
    b++;
}
Console.WriteLine(b);