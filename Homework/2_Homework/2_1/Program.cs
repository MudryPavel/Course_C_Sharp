// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondDigit(int num)
{
    return(((num%100)-(num%10))/10);
}
Console.WriteLine("Write a 3-digit number a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(SecondDigit(a));