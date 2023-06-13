// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

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