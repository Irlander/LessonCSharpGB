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
    int origin = number;
    int temp = number % 10;
    number = number / 10;
    int palindrome = temp;
    while (number > 0)
    {
        temp = number % 10;
        number = number / 10;
        palindrome = palindrome * 10 + temp;
    }
    if (origin == palindrome)
    {
        Console.WriteLine($"Число {origin} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {origin} не является палиндромом");
    }
}