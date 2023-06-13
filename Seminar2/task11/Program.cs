// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
using System;

int numberRandom = Random.Shared.Next(100, 1000);
Console.WriteLine(numberRandom);
int firstDigit = numberRandom / 100;
Console.WriteLine(firstDigit);
int lastDigit = numberRandom % 10;
Console.WriteLine(lastDigit);
int midDigit = firstDigit * 10 + lastDigit;
Console.WriteLine(midDigit);