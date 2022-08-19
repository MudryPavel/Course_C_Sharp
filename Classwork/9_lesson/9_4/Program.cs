// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

int Pow(int num, int mult)
{
    if(mult==0) return 1;
    return Pow(num, mult-1) *num;

}
Console.WriteLine(Pow(5,4));