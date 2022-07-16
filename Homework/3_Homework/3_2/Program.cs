// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Lenght3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)));
}
Console.Write("Enter x1: ");
double x1=double.Parse(Console.ReadLine());
Console.Write("Enter y1: ");
double y1=double.Parse(Console.ReadLine());
Console.Write("Enter z1: ");
double z1=double.Parse(Console.ReadLine());
Console.Write("Enter x2: ");
double x2=double.Parse(Console.ReadLine());
Console.Write("Enter y2: ");
double y2=double.Parse(Console.ReadLine());
Console.Write("Enter z2: ");
double z2=double.Parse(Console.ReadLine());
Console.WriteLine(Lenght3D(x1, y1, z1, x2, y2, z2));
// Console.WriteLine(Lenght3D(0,0,0,3,4,12));
