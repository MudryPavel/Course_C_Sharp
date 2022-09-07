// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

void PrintArray(string[] array)
{
    foreach(string newString in array)
        Console.Write($"{newString},  ");
}
string[] Array3Symb(string[] array1)
{
    string[] array2=new string[array1.Length];
    int Count=0;
    foreach(string newString in array1)
    {
        if(newString.Length<=3)
        {
            array2[Count]=newString;
            Count++;
        }
    }
    Array.Resize<string>(ref array2,Count);
    return array2;
}
string[] Test=new string[5] {"AAAAAAA","Bb","Ccc","D","E"};
PrintArray(Test);
Console.WriteLine("");
string[] Test2=Array3Symb(Test);
PrintArray(Test2);