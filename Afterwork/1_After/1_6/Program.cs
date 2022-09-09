int startValue = int.Parse(Console.ReadLine()); 
int endValue = int.Parse(Console.ReadLine()); 
int sum = 0;
int[] simples = new int[100];
simples[0]=2;
simples[1]=3;
int count = 2; 
for (int i = startValue; i <= endValue; i++) 
{   
    int flag = 0;
    for (int j = 0; simples[j] <= Math. Sqrt(i) && flag==0 && simples[j]!=0; j++) 
    { 
        if (i % simples[j] == 0) 
            flag=1;      
    }
    if(flag==0)
    {
        simples[count]=i; 
        Console.WriteLine(i);
        sum = sum + i;
        count++;
    }     
} 
 
Console.WriteLine($"Сумма простых чисел = {sum}");
