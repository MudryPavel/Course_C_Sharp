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

int [,] Spiral2xArray(int row, int column)
{ 
    int[,] array = new int[row,column];
    
    for(int k=0; k<row; k++)
    {
        for(int l=0; l<column; l++)
        {
            array[k,l]=0;
        }
    }
        
    int i=0;
    int j=0;
    int iNew=0;
    int jNew=0;
    int[]direction ={0,1};
   
    for (int Index=1;Index<=row*column;Index++)
    {
        array[i,j]=Index;
        iNew=i+direction[0];
        jNew=j+direction[1];
        if(iNew>=0 && iNew<row && jNew>=0 && jNew<column && array[iNew,jNew]==0)
        {
            i+=direction[0];
            j+=direction[1];
        }
        else
        {
            DirectionChange(direction);
            i+=direction[0];
            j+=direction[1];
        }
    }
   return array;
}

int [,] SpiralFill2xArray(int[,] array)
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1);
    int i=0;
    int j=0;
    int iNew=0;
    int jNew=0;
    int[]direction ={0,1};
   
    for (int Index=1;Index<=row_size*column_size;Index++)
    {
        array[i,j]=Index;
        iNew=i+direction[0];
        jNew=j+direction[1];
        if(iNew>=0 && iNew<array.GetLength(0) && jNew>=0 && jNew<array.GetLength(1) && array[iNew,jNew]==0)
        {
            i+=direction[0];
            j+=direction[1];
        }
        else
        {
            DirectionChange(direction);
            i+=direction[0];
            j+=direction[1];
        }
    }
   return array;
}

int[,] Array1= Fill2xArray(5,5,0,0);
Print2xArray(Array1);
int[,] Array2 = Spiral2xArray(5,5);
Print2xArray(Array2);