Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());
if (a==0)
{
    Console.WriteLine("0");
}
else
{
int i=-a;
while (i*Math.Sign(i) <= a * Math.Sign(a))
{
    Console.WriteLine(i);
    i+=Math.Sign(a);
}
}