// See https://aka.ms/new-console-template for more information
char sex=Convert.ToChar(Console.ReadLine());
int number=Convert.ToInt32(Console.ReadLine());
if (sex == 'F')
{
    Console.WriteLine("800米长跑");
    if (number % 2 == 1)
    {
        Console.WriteLine("跳绳");
    }
    else
    {
        Console.WriteLine("跳绳");
    }
}
else
{
    Console.WriteLine("1000米长跑");
    if (number % 2 == 1)
    {
        Console.WriteLine("跳远");
    }
    else
    {
        Console.WriteLine("俯卧撑");
    }
}