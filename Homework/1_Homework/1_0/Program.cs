// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Write number: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Last digit is ");
Console.WriteLine(a%10);