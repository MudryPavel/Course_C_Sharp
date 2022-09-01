// Бинарный поиск поиск числа в массиве

int[] FillArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(1, 101);
    }
    return array;
}

int[] SortArray (int[] array)
{
    int size = array.Length;
    for (int j = 0; j < size; j++)
    {
        for (int i = 0; i < size-1-j; i++)
        {
            if (array[i] > array[i + 1])
                (array[i],array[i+1]) = (array[i+1],array[i]);
        }
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($"{array[i]} ");
    }
}


int BinarySearch (int[] array, int find)
{
    int low = 0;
    int high = array.Length - 1;
    int middle = (array.Length+1) / 2;
    int guess = 0;
    int flag = 0;
    int pos = 0;
    while (low <= high && flag == 0)
    {
        middle=((high+low)/2);
        Console.WriteLine ($"{low}, {middle}, {high}");
        guess = array[middle];
        if (guess == find)
            {
            flag=1;
            pos=middle+1;
            }
        else if (guess > find)
            high = middle-1 ;
        else
            low = middle+1 ;   
    }
    if (guess == find)
            {
            middle=((high+low)/2);
            Console.WriteLine ($"{low}, {middle}, {high}");
            guess = array[middle];
            flag=1;
            pos=middle+1;
            }
    if (flag == 1)
    {
        Console.WriteLine ($"{find} is on {pos} position in array");
        return pos;
    }
    else
    {
        Console.WriteLine ($"{find} isn't found in array");
        return 1000000;
    }
}

int[] newArr = FillArray(8);
PrintArray(newArr);
SortArray(newArr);
Console.WriteLine();
PrintArray(newArr);

Console.WriteLine ("Write a wanted number: ");
int a = int.Parse(Console.ReadLine());

// Console.Write ($"Position of wanted number {BinarySearch(newArr, a)} ");
BinarySearch(newArr, a);