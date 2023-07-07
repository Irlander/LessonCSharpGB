// Задача 67: Напишите программу, которая будет принимать на вход
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int GetSumma(int value)
{
    if(value <= 0) return 0;
    return GetSumma(value / 10) + value % 10;
}

int result = GetSumma(number);
Console.WriteLine(result);