// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.

int DigitSum(int num)
{
    if(num==0) return 0;
    return DigitSum(num/10) + num%10;

}
Console.WriteLine(DigitSum(9999));