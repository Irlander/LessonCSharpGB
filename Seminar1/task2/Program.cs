// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;

Console.WriteLine("Введите первое число:");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string? numberStringTwo = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if (numberIntOne >= numberIntTwo)
{
    Console.WriteLine("Max = "+ numberIntOne);
}
else
{
    Console.WriteLine("Max = "+ numberIntTwo);
}