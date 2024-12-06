// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
int b = 0;
while (a != 1)
{
    if (a % 2 == 0)
    {
        a = 3 * a + 1;
    }
    else
    {
        a = a / 2;
    }
    b++;
    Console.WriteLine(a);
}
