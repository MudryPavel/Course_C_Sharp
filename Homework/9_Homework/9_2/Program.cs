// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumMinMax(int min, int max)
{
    if(min==max) return max;
    return SumMinMax(min, max-1) +max;

}
Console.WriteLine(SumMinMax(1,40));
