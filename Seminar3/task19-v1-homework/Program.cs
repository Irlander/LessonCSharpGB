// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());   //ввод числа
if (number < 10000 || number > 99999)   //проверка на 5 цифр в числе
{
    Console.WriteLine("Число содержит менее или более 5 цифр");
}
else
{
    int numberFirst = number / 10000;    //получаем 1 цифру
    int numberFive = number % 10;   //получаем 5 цифру
    number = (number - numberFirst * 10000) / 10;   //получаем три цифры по центру числа
    int numberTwo = number / 100;   //получаем 2 цифру
    int numberFour = number % 10;   //получаем 4 цифру
    if (numberFirst == numberFive && numberTwo == numberFour)   //сравниваем 1 и 5, 2 и 4 цифры
    {
        Console.WriteLine("Число является палиндромом");   //вывод
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");   //вывод
    }
}