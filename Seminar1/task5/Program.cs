using System;
Console.WriteLine("Введите число:");
string? numberStringN = Console.ReadLine();
int numberN = Convert.ToInt32(numberStringN);
for (int i = -numberN; i <= numberN; i++)
{
    Console.Write(i);
    if (i != numberN)
        {
        Console.Write(", ");
        }
}