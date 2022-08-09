// 2. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string ChangeNum (int num)
{
    string result = "";
    while (num>0)
    {
        result = num%2 + result;
        num /= 2;
    }
    return result;
}


Console.WriteLine ($"12 -> {ChangeNum (12)}");