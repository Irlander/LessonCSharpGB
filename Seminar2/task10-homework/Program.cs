// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (100 <= number && number <= 999)
{
    number = number / 10;
    number = number % 10;
    Console.WriteLine($"Вторая цифра равна {number}");
}
else
{
    Console.WriteLine("Ошибка ввода");
}