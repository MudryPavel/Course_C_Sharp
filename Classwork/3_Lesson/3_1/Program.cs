// See https://aka.ms/new-console-template for more information
double Quater(double num1, double num2)
{
    if (num1==0 || num2==0)
    {
        return(0);
    }
    else 
    {
        double quat=(2.5- Math.Sign(num2)*(1+0.5*Math.Sign(num1)));
        return(quat);
    }
}
Console.WriteLine(Quater(-1,-2));