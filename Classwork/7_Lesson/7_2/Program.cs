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
int[,] ReplaceElOn2ndPos2xArray(int[,] arr)
{
    for(int i=1; i<arr.GetLength(0); i+=2)
    {
        for(int j=1; j<arr.GetLength(1); j+=2)
        {
            arr[i,j]*=arr[i,j];
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return(arr);
}

int[,] arr1 = Fill2xArray(4,4,-10,10);
Print2xArray(arr1);
ReplaceElOn2ndPos2xArray(arr1);
Print2xArray(arr1);