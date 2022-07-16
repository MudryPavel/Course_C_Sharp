// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Enter N: ");
int N=int.Parse(Console.ReadLine());
int CubeTable(int a)
{
    int i=1;
    for(i=1;i<=a;i++)
        Console.Write($"{Math.Pow(i,3)} ");
    return(0);
}
CubeTable(N);