// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

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

void SortMaxToMin2xArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for(int i=0; i<row_size;i++)
    {
        for(int j=0; j<column_size-1; j++)
        {
            for(int k=0; k<column_size-j-1; k++)
            {
                if(arr[i,k]<arr[i,k+1])
                (arr[i,k],arr[i,k+1])=(arr[i,k+1],arr[i,k]);
            }
        }
    } 
}

int[,] Array1=Fill2xArray(4,20,1,10);
Print2xArray(Array1);
SortMaxToMin2xArray(Array1);
Print2xArray(Array1);