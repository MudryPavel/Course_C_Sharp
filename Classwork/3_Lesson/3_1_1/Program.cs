//Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

void Quarters (int a)
{
    if (a==1)
        Console.WriteLine("x > 0, y > 0");
    else if (a==2)
        Console.WriteLine("x < 0 && y > 0");
    else if (a==3)
        Console.WriteLine("x < 0 && y < 0");
    else if (a==4)
        Console.WriteLine("x > 0 && y < 0");
    else 
        Console.WriteLine("error");
}

Quarters(1);
Quarters(2);
Quarters(3);
Quarters(4);
Quarters(-9);
