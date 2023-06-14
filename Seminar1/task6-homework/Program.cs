// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

using System;

Console.WriteLine("Введите число:");
string? numberString = Console.ReadLine();

int number = Convert.ToInt32(numberString);

if (number % 2 == 0)
{
    Console.WriteLine(number + " чётное число.");
}
else
{
    Console.WriteLine(number + " нечётное число.");
}