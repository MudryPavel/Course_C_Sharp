int[] RandomMegaSuperStrongArray()
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
int ArrayElementSuperCounter(int[] array)
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
ArrayElementSuperCounter(RandomMegaSuperStrongArray());

