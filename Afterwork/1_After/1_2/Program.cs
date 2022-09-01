// Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

int [,,] MussNums (int row, int column, int height)
{
    int [,,] arr = new int[row, column, height];
    int num = 10;

    if (row * column * height >= 90)
        Console.WriteLine ("Error");

    else
    {
        for (int i=0; i< row; i++)
        {
            for (int j=0; j< column; j++)
            {
                for (int k=0; k< height; k++)
                {
                    arr[i, j, k] = num;
                    num++;
                }
            }
        }
    }
    return arr;
}

void PrintArray (int[,,] arr)
{
    int rowSize = arr.GetLength(0);
    int columnSize = arr.GetLength(1);
    int heightSize = arr.GetLength(2);

    for (int k=0; k< heightSize; k++)
    {
        for (int i=0; i< rowSize; i++)
        {
            for (int j=0; j< columnSize; j++)
            {
                Console.Write ($" {arr[i, j, k], 7} ");
            }
            Console.WriteLine();

            for (int j=0; j< columnSize; j++)
            {
                Console.Write ($" {i}, {j}, {k}   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine ("Write a number of row: ");
int row = int.Parse(Console.ReadLine());

Console.WriteLine ("Write a number of column: ");
int column = int.Parse(Console.ReadLine());

Console.WriteLine ("Write a number of height: ");
int height = int.Parse(Console.ReadLine());

int [,,] newArr = MussNums(row, column, height);

PrintArray (newArr);