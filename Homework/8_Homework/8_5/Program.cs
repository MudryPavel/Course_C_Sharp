// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
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

int[,] DelLowElementRowColumn2xArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    
    int[,] NewArr = new int[row_size-1,column_size-1];
    int[] minElement=new int[2]{0,0};
    int min=arr[0,0];
    for(int i=0; i<row_size;i++)
    {
        for(int j=0; j<column_size; j++)
        {
            if(arr[i,j]<min)
            {
                min=arr[i,j];
                minElement[0]=i;
                minElement[1]=j;
            }
        }
    }
    int k=0;
    for(int i=0; i<row_size;i++)
    {
        int l=0;
        if(i !=minElement[0])
        {
            for(int j=0; j<column_size; j++)
            {
                if(j!=minElement[1])
                {
                    NewArr[k,l]=arr[i,j];
                    l++;
                }
            }
        k++;
        }
    }

    return(NewArr); 
}

int[,] Array1=Fill2xArray(5,5,0,100);
Print2xArray(Array1);
DelLowElementRowColumn2xArray(Array1);
int[,] Array2=DelLowElementRowColumn2xArray(Array1);
Print2xArray(Array2);