﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Enter the 5-digit number: ");
int Number=int.Parse(Console.ReadLine());
double Digit(double a,double b)
{
    return((Math.Floor(a/(Math.Pow(10,Math.Floor(Math.Log10(a))-b+1)))%10));
}
int PaLLindromCheck(int a)
{
    int NumOfDigits = (int)(Math.Log10(a)+1);
    int i;
    for(i=1;i<=(NumOfDigits/2-1);i++)
    {
        //Console.WriteLine(Digit(a,i));
        //Console.WriteLine(Digit(a,NumOfDigits+1-i));
        if(Digit(a,i)==(Digit(a,NumOfDigits+1-i)))
        {
            Console.WriteLine($"Digit {i} is the same as digit {NumOfDigits+1-i}");
        }
        else
        {
            break;
        }
    }
    if(Digit(a,i)==(Digit(a,NumOfDigits+1-i)))
        {
            Console.WriteLine($"Digit {i} is the same as digit {NumOfDigits+1-i}, {a} is a pallindrom");
        }
        else
        {
            Console.WriteLine($"Digit {i} is not the same as digit {NumOfDigits+1-i}, {a} is not a pallindrom");
        }
    Console.Write($"Number of digit's in {a} = ");
    return(NumOfDigits);
}
//Console.WriteLine(Digit(19991,2));
Console.WriteLine(PaLLindromCheck(Number));
Console.WriteLine(PaLLindromCheck(1234554321));
