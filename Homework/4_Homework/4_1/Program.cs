// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.

int NumExp(int num, int a)
{
    int Mult = 1;
    for(int i=1; i <= a; i++)
        Mult *= num;
    return Mult;
}
Console.WriteLine(NumExp(7,2));