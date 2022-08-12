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

int SumMainDiagArray(int[,] arr)
{
    int Sum = 0;
    int minLenght = arr.GetLength(0);
    if (arr.GetLength(1)<arr.GetLength(0))
        minLenght = arr.GetLength(1);

    for(int i=0; i<minLenght; i++)
    {
        Sum+=arr[i,i];
    }
    Console.Write($"Sum of elements on main diagonal = {Sum} ");
    return(Sum);
}


int[,] arr1 = Fill2xArray(4,4,-10,10);
Print2xArray(arr1);
SumMainDiagArray(arr1);
