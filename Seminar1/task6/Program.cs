// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;

Console.WriteLine("Введите число:");
string? numberStringOne = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);

if (numberIntOne % 2 == 0)
{
    Console.WriteLine(numberIntOne + " чётное число.");
}
else
{
    Console.WriteLine(numberIntOne + " нечётное число.");
}