Console.WriteLine("Write a weekday number: ");
int a = int.Parse(Console.ReadLine());
if (a == 1)
    Console.WriteLine("пн");
else if (a == 2)
    Console.WriteLine("вт");
else if (a == 3)
    Console.WriteLine("ср");
else if (a == 4)
    Console.WriteLine("чт");
else if (a == 5)
    Console.WriteLine("пт");
else if (a == 6)
    Console.WriteLine("сб");
else if (a == 7)
    Console.WriteLine("вс");
else Console.WriteLine("Ну алло, цифру от 1 до 7 можно ввести корректно??!!!!");