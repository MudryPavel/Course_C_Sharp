﻿// See https://aka.ms/new-console-template for more information
int SumNum(int num)
{
    int all_sum = 0;
    for(int i=1; i <= num; i++)
        all_sum += i;
    return all_sum;
}
Console.WriteLine(SumNum(4));

