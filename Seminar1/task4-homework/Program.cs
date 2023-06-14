// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;

Console.WriteLine("Введите первое число:");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число:");
string? numberStringTwo = Console.ReadLine();

Console.WriteLine("Введите третье число:");
string? numberStringThree = Console.ReadLine();

int numberOne = Convert.ToInt32(numberStringOne);
int numberTwo = Convert.ToInt32(numberStringTwo);
int numberThree = Convert.ToInt32(numberStringThree);

if (numberOne >= numberTwo)
{
    numberTwo = numberOne;
}

if (numberTwo >= numberThree)
{
    numberThree = numberTwo;
}

 Console.WriteLine("Максимальное число равно "+ numberThree);