// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.

int[] CreateArray()
{
    Console.WriteLine("Input number of elements");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's min");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's max");
    int max = int.Parse(Console.ReadLine());
    int[] array = new int[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().Next(min, max+1);
        Console.Write($"{array[i]} ");
    }
    return(array);
}
int[] ArrayElementSignChanger(int[] array1)
{
    for(int i=0; i < array1.Length; i++)
    {
        array1[i]*=-1;
    }
    for(int i=0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");         
    }
    return(array1);    
}
ArrayElementSignChanger(CreateArray());