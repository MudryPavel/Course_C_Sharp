// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int SecondDigitDeletion(int num)
{
    return((num/100)*10+(num%10));
}
Console.WriteLine("Write a 3-digit number a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(SecondDigitDeletion(a));
