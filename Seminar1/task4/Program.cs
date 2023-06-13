// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

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