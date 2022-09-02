// Даны два двумерных массива одинаковых размеров.
// Создать третий массив такого же размера, каждый элемент которого
// равен сумме соответствующих элементов двух первых массивов.
// Создать четвертый массив такого же размера, каждый элемент которого
// равен 100, если соответствующие элементы двух первых массивов имеют
// одинаковый знак, и равен нулю в противном случае.

void Print2xArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i=0; i<row_size; i++)
    {
        for(int j=0; j<column_size; j++)
        {
            Console.Write($"{arr[i, j],4} ");
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

int[,] Sum2xArray(int[,] array1, int[,] array2)
{
    int row_size = array1.GetLength(0);
    int column_size = array1.GetLength(1);
    int[,]array3 = new int[row_size,column_size];
    if (array1.GetLength(0)==array2.GetLength(0) && array1.GetLength(1)==array2.GetLength(1))
    {
        for(int i=0; i<row_size; i++)
        {
            for(int j=0; j<column_size; j++)
            {
                array3[i,j]=array1[i,j]+array2[i,j];
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Arrays are not the same size");
    }        
    return array3;
}

int[,] Check2xArray(int[,] array1, int[,] array2)
{
    int row_size = array1.GetLength(0);
    int column_size = array1.GetLength(1);
    int[,]array3 = new int[row_size,column_size];
    if (array1.GetLength(0)==array2.GetLength(0) && array1.GetLength(1)==array2.GetLength(1))
    {
        for(int i=0; i<row_size; i++)
        {
            for(int j=0; j<column_size; j++)
            {
                if(array1[i,j]*array2[i,j]>0)
                    array3[i,j]=100;
                else
                    array3[i,j]=0;
            }
            
        }
        
    }
    else
    {
        Console.WriteLine("Arrays are not the same size");
    }        
    return array3;
}

int[,] Array1 = Fill2xArray(5,5,-10,10);
int[,] Array2 = Fill2xArray(5,5,-10,10);
Print2xArray(Array1);
Print2xArray(Array2);
int[,] Array3 = Sum2xArray(Array1,Array2);
Print2xArray(Array3);
int[,] Array4 = Check2xArray(Array1,Array2);
Print2xArray(Array4);
