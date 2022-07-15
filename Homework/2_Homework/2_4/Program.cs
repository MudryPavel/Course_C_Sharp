// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Enter the number of weekday: ");
int Number=int.Parse(Console.ReadLine());
if (Number>7 || Number<1)
{
    Console.WriteLine("Not correct day");
}
else
if(Number>5)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий день");
}
