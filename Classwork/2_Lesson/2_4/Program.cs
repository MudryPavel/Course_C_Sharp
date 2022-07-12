// See https://aka.ms/new-console-template for more information
void Method2 (int Number, int Del_1, int Del_2)
{
    if (Number%Del_1==0 & Number%Del_2==0)
        {
        Console.WriteLine($"{Number} кратно {Del_1} и {Del_2}");
        }
    else
        if (Number%Del_1==0)
            {
            Console.WriteLine($"{Number} кратно {Del_1},но не кратно {Del_2}");
            }
        else
            if (Number%Del_2==0)
               {
               Console.WriteLine($"{Number} кратно {Del_2},но не кратно {Del_1}");
               } 
            else
                {
                Console.WriteLine($"{Number} не кратно {Del_1} и {Del_2}");
                }
}

Method2(305, 65, 6);