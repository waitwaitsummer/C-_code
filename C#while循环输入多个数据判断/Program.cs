// See https://aka.ms/new-console-template for more information
int a = int.Parse(Console.ReadLine());
int b = 1;
int sum = 0;
while (b < a + 1)
{
    sum = sum + int.Parse(Console.ReadLine());
    b++;
}
double pj=1.0*sum/a;
pj = ((int)(pj * 100)) / 100.0;
Console.WriteLine(pj);
