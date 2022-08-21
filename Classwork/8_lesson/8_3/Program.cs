void Print(int[,] array) 
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1); 
    for (int i = 0; i < row_size; i++) 
    { 
        for (int j = 0; j < column_size; j++) 
        { 
            Console.Write($" {array[i, j]} "); 
        } 
        Console.WriteLine(); 
    } 
    Console.WriteLine(); 
} 
 
 
int [,] MassNum(int row, int column, int from , int  to) 
{ 
    int[,] array = new int [row, column]; 
 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < column; j++) 
        { 
            array[i, j] = new Random().Next(from,to); 
        }  
    } 
    return array; 
} 
 
int [] MinSearch (int [,] array) 
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1); 
    int min = array[0,0]; 
    int [] index = new int [2]; 
    for (int i = 0; i < row_size; i++) 
    { 
        for (int j = 0; j < column_size; j++) 
        { 
            if (min > array [i,j]) 
            { 
                min = array [i,j]; 
                index [0] =i; 
                index [1] =j; 
            } 
        } 
         
    } 
    return index; 
} 
 
void DeleteRowColumn (int [,] array, int  [] index) 
{ 
    int row_size = array.GetLength(0); 
    int column_size = array.GetLength(1); 
    for (int i = 0; i < row_size; i++) 
    { 
        for (int j = 0; j < column_size; j++) 
        { 
            if (index [0] == i || index [1] == j) 
            { 
                continue; 
            } 
            else 
            { 
                Console.Write($" {array[i, j]} "); 
            } 
        } 
        Console.WriteLine (); 
    } 
} 
Console.Write( "Enter the numbers of rows:"); 
int row = int.Parse(Console.ReadLine()); 
Console.Write( "Enter the numbers of columns:"); 
int column = int.Parse(Console.ReadLine()); 
int [,] arr_1 = MassNum (row, column, 1, 11); 
Print (arr_1); 
int [] new_arr =MinSearch (arr_1); 
DeleteRowColumn (arr_1, new_arr);