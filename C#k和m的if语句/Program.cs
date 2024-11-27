// See https://aka.ms/new-console-template for more information
double m = Convert.ToDouble(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());
if (k == 0)
{
    int a = (int)m;
    Console.WriteLine(a);
}
else if (k == 1)
{
    double b = ((int)((m + 0.05) * 10)) / 10.0;
    Console.WriteLine(b);
}