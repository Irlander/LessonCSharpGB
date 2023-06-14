// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

using System;

Console.WriteLine("Введите первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne * numberOne == numberTwo || numberTwo * numberTwo == numberOne)
{
    if (numberOne >= numberTwo)
    {
        Console.WriteLine($"{numberOne} является квадратом {numberTwo}");
    }
    else
    {
        Console.WriteLine($"{numberTwo} является квадратом {numberOne}");
    }
}
else
{
    Console.WriteLine("Нет числа, которое является квадратом другого числа"); 
}