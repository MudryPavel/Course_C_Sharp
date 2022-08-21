// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// Значения элементов массива 0..9


void Print2xArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i=0; i<row_size; i++)
    {
        for(int j=0; j<column_size; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Fill2xArray(int row, int column, int min, int max)
{
    int[,] arr = new int[row,column];
    
    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            arr[i,j]=new Random().Next(min,max+1);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return(arr);
}

void QuantDictionary(int[,] arr)
{
    int[] numbers=new int[10];
    foreach (int i in arr)
        numbers[i]++;
    for(int j=0; j<10;j++)
        Console.WriteLine($"{j} is meet in array {numbers[j]} times");
}

int[,] Array1=Fill2xArray(5,5,0,9);
Print2xArray(Array1);
QuantDictionary(Array1);
