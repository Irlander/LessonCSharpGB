﻿// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());   //ввод числа
if (number < 10000 || number > 99999)   //обработка исключения
{
    Console.WriteLine("Число содержит менее или более 5 цифр");
}
else
{
    int origin = number;   //запоминаем введенное число
    int palindrome = 0;   //создаём переменную для палиндрома
    while (number > 0)   //циклом запоминаем в переменную введенное число в обратном порядке
    {
        int temp = number % 10;
        number = number / 10;
        palindrome = palindrome * 10 + temp;
    }
    if (origin == palindrome)   //вывод ответа
    {
        Console.WriteLine($"Число {origin} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {origin} не является палиндромом");
    }
}