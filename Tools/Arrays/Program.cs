// Генерация массива заданной длины с указанными мин и макс значениями элементов
int[] RandomArray()
{
    Console.WriteLine("Input number of elements");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's min");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's max");
    int max = int.Parse(Console.ReadLine());
    int[] array = new int[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().Next(min, max+1);
        Console.Write($"{array[i]} ");
    }
    return(array);
}

// Сумма положительных или отрицательных элементов массива
int ArrayElementBySignSumCounter(int[] array)
{
    Console.WriteLine("Input sign of counting elements");
    int s = int.Parse(Console.ReadLine());
    int Sum=0;
    for(int i=0; i < array.Length; i++)
    {
        if(Math.Sign(array[i])==s)
            Sum+=array[i]; 
    }
    Console.WriteLine($"{Sum}");
    return(Sum);    
}

// Счетчик количества элементов с указанным значением
void ArrayElementCounter(int[] array)
{
    Console.WriteLine("Input counting value");
    int s = int.Parse(Console.ReadLine());
    int a=0;
    for(int i=0; i < array.Length; i++)
    {
        
        if(array[i]==s)
            a+=1;     
    }
    if (a==0)
        Console.WriteLine("This value isn't found in array");
    else
        Console.WriteLine($"This value is found in array {a} times");
}

// Счетчик количества и суммы элементов в указанном интервале
void ArrayElementSumCounter(int[] array1)
{
    Console.WriteLine("Input element's counting min");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Input element's counting max");
    int max = int.Parse(Console.ReadLine());
    int a=0;
    int Sum=0;
    for(int i=0; i < array1.Length; i++)
    {
        
        if(array1[i]>=min&&array1[i]<=max)
        {
            a+=1;
            Sum+=array1[i];
        }         
    }
    if (a==0)
        Console.WriteLine("This values isn't found in array");
    else
        Console.WriteLine($"This values is found in array {a} times, Sum of these elements is {Sum}");
}

// Смена знака элементов массива на противоположный
int[] ArrayElementSignChanger(int[] array1)
{
    for(int i=0; i < array1.Length; i++)
    {
        array1[i]*=-1;
    }
    for(int i=0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");         
    }
    return(array1);    
}

// Разность максимального и минимального элементов массива
int ArrayMinMaxDelta(int[] array1)
{
    int Min = array1[0];
    int Max = array1[0];
    for(int i=1; i < array1.Length; i++)
    {
        if(array1[i]<Min)
            Min = array1[i];
        if(array1[i]>Max)
            Max = array1[i];    
    }
    Console.WriteLine();
    Console.WriteLine($"{Max-Min} ");
    return(Max-Min);
}