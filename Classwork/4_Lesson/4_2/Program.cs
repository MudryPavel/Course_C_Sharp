//Напишите программу, которая 
//принимает на вход число N и выдаёт 
//произведение чисел от 1 до N.

int Factorial(int num)
{
    int fact = 1;
    for(int i=1; i <= num; i++)
        fact *= i;
    return fact;
}
Console.WriteLine(Factorial(7));