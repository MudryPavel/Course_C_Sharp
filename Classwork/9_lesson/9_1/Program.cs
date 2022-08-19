// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void ValueSet(int max)
{
    if (max==0) return;
    ValueSet(max-1);
    Console.Write($"{max}, ");
}

ValueSet(5);