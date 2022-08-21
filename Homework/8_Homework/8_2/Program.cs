// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

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

void FindMinRow2xArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[] Sum= new int[row_size];
    int minRow=0;
    
    for(int i=0; i<row_size; i++)
    {
        for(int j=0; j<column_size; j++)
        {
            Sum[i]+=arr[i,j];
        }
        Console.Write($"{Sum[i]}; ");
        if (Sum[i]<Sum[minRow])
            minRow=i;
    }
    Console.WriteLine();
    Console.WriteLine($"{minRow+1} is row with lowest Sum of elements in Array");
}


int[,] Array1=Fill2xArray(4,4,1,10);
Print2xArray(Array1);
FindMinRow2xArray(Array1);
