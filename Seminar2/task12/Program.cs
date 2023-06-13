//Напишите программу, которая будет принимать на вход
//два числа и выводить, является ли второе число кратным первому.
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.

using System;

int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());

int result = numberOne % numberTwo;

if (result != 0)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Второе число кратно первому");
}