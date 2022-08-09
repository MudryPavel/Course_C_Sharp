void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int[] ReverseArray(int[] array)
{
    int size = array.Length -1;
    for(int i=0;i<size/2;i++)
        (array[i],array[size-i]) = (array[size-i], array[i]);
    return array;    
}
int[] arr_1 = MassNums(6, 1, 21);
Print(arr_1);
ReverseArray(arr_1);
Print(arr_1);