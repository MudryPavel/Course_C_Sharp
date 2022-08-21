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

int ElementCheckArray(int[,] arr)
{
    Console.WriteLine("Write a number to check: ");
    int Check = int.Parse(Console.ReadLine());
    int Quant = 0;
    int[,] ResArray= new int[10,2];     
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            if(arr[i,j]==Check)
            {
                ResArray[Quant,0]=i+1;
                ResArray[Quant,1]=j+1;
                Quant++;
            }

        }
        Console.WriteLine();
    }
    Print2xArray(ResArray);
    return(Quant);
}

int[,] arr1 = Fill2xArray(6,6,-10,10);
Print2xArray(arr1);
ElementCheckArray(arr1);