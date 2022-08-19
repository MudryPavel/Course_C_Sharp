// Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void ValueSetMinMax(int min, int max)
{
    if (max<min) return;
    ValueSetMinMax(min,max-1);
    Console.Write($"{max}, ");
}

ValueSetMinMax(3,10);