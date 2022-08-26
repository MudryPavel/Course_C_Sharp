// Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7

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

int []DirectionChange(int[]direction)
{
    if (direction[0]==0 && direction[1]==1)
    {
        direction[0]=1; 
        direction[1]=0;
    }
    else
    {
        if (direction[0]==1 && direction[1]==0)
        {
            direction[0]=0; 
            direction[1]=-1;
        }
        else
        {
            if (direction[0]==0 && direction[1]==-1)
            {
                direction[0]=-1; 
                direction[1]=0;
            }
            else
            {
                if (direction[0]==-1 && direction[1]==0)
                {
                    direction[0]=0; 
                    direction[1]=1;
                }
            }
        }
    }
    return direction;
}
int [,] SpiralFill2xArray(int[,] array)
{
    
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1);
    int i=0;
    int j=0;
    int[]direction ={0,1};
   
    for (int Index=1;Index<=row_size*column_size;Index++)
    {
        if(i>=0 && i<array.GetLength(0) && j>=0 && j<array.GetLength(1) && array[i,j]==0)
        {
            array[i,j]=Index;
            i+=direction[0];
            j+=direction[1];
        }
        else
        {
            i-=direction[0];
            j-=direction[1];
            DirectionChange(direction);
            i+=direction[0];
            j+=direction[1];
            array[i,j]=Index;
            i+=direction[0];
            j+=direction[1];
        }
               
   }
   return array;
}

int[,] Array1= Fill2xArray(9,9,0,0);
Print2xArray(Array1);
SpiralFill2xArray(Array1);
Print2xArray(Array1);