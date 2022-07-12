// See https://aka.ms/new-console-template for more information
void Method1 (int a, int b)
{
    if (a % b ==0)
        {
            Console.WriteLine($"{a} кратно {b}");
        }
    else
        {
        Console.WriteLine($"{a} не кратно {b}, остаток {a%b}");
        }
}

Method1(34,5);