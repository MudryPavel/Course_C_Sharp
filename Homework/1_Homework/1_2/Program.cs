// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number c: ");
int c = int.Parse(Console.ReadLine());

int max=a;
if (b > max)
max=b;
if (c > max)
max=c;

Console.Write("max=");
Console.WriteLine(max);