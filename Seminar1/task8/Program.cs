// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;

Console.WriteLine("Введите положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    for (int count = 2; count <= number; count = count + 2)
    {
        Console.Write(count);
    }
}
else
{
    Console.WriteLine("Введено число, которое не удовлетворяет требования");
}