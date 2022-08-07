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
    Console.WriteLine();
    return(array);
}

int[] MultCountArray(int[] array1)
{
    int[] array2 = new int[(array1.Length/2)+array1.Length%2];
    for(int i=0; i < array1.Length/2; i++)
    {
        array2[i]=array1[i]*array1[array1.Length-1-i];
        Console.Write($"{array2[i]} ");
    }
    if(array1.Length%2==1)
    {
        array2[array2.Length-1]=array1[array2.Length-1];
        Console.Write($"{array2[array2.Length-1]} ");
    }
    return(array2);
}
MultCountArray(CreateArray());
