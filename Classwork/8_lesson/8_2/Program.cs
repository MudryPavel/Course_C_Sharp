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

void RowsColumnsChange (int[,] arr1)
{
    if(arr1.GetLength(0)!=arr1.GetLength(1))
        Console.WriteLine("Number of rows and columns are different");
    else
        for(int i=0; i<arr1.GetLength(0); i++)
            for(int j=0; j<i && j<arr1.GetLength(1); j++)
                (arr1[i,j],arr1[j,i])=(arr1[j,i],arr1[i,j]);
}

int[,] Array1=Fill2xArray(4,4,1,10);
Print2xArray(Array1);
RowsColumnsChange(Array1);
Print2xArray(Array1);