// Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции.

int[] RandomArray(int num)
{
    int[] array1 = new int[num];
    for(int i=0; i < num; i++)
        array1[i]=new Random().Next();
    return array1;
}

void ArrayOutput(int[] array2)
{
    for(int i=0; i < array2.Length; i++)
        Console.Write($"{array2[i]} ");
}
ArrayOutput(RandomArray(8));