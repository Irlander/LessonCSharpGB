﻿// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите минимальное число");
int valueMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число");
int valueMax = Convert.ToInt32(Console.ReadLine());

void NaturalNumber (int numberMin, int numberMax)
{
    if (numberMax <= numberMin)
    {
        Console.Write(numberMin + " ");
        return;
    }
    NaturalNumber(numberMin, numberMax - 1);
    Console.Write(numberMax + " ");
}

NaturalNumber(valueMin, valueMax);