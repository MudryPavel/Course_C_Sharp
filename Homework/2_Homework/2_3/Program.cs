// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
double ThirdDigit(double num)
{
    if (num*Math.Sign(num)<100)
    {
        Console.WriteLine("Нет третьей цифры");
        return(0);
    }
    else
    return(Math.Floor(num/(Math.Pow(10,Math.Floor(Math.Log10(num))-2)))%10);
    // return((num/100)*10+(num%10));Math.
}
Console.WriteLine("Write a  number: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine(ThirdDigit(a));
