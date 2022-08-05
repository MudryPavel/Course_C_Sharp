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
    if (s==0)
        Console.WriteLine("This value isn't found in array");
    else
        Console.WriteLine($"This value is found in array {a} times");
}
ArrayElementCounter(CreateArray());    