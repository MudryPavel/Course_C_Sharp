// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void Quad(int x)
{
    int i=1;
    for(i=1;i<=x;i++)
    {
    Console.WriteLine(Math.Pow(i,2));
    }
}
Quad(5);
