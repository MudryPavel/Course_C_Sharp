//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Write quantity of numbers: ");
int num = int.Parse(Console.ReadLine());
int a = 0;
int Positive = 0;
for(int i=0;i<num;i++)
{
    Console.WriteLine("Write number: ");
    a = int.Parse(Console.ReadLine());
    if(a>0)
        Positive++;
}
Console.WriteLine($"{Positive} numbers are positive");