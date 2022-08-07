int[] CreateArray()
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
void ArrayElementSuperCounter(int[] array1)
{
    Console.WriteLine("Input elemet's counting min");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's counting max");
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
ArrayElementSuperCounter(CreateArray());