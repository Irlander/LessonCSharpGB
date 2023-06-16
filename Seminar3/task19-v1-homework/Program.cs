// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("Число содержит менее или более 5 цифр");
}
else
{
    int numberFirst = number / 10000;
    int numberFive = number % 10;
    number = (number - numberFirst * 10000) / 10;
    int numberTwo = number / 100;
    int numberFour = number % 10;
    if (numberFirst == numberFive && numberTwo == numberFour)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}