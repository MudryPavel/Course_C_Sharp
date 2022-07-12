// See https://aka.ms/new-console-template for more information

int MaxDigit(int Number)
{
    if (Number / 10 > Number %10)
        return Number / 10;
    else
        return Number %10;
}
int a = new Random().Next(10,100);
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));
