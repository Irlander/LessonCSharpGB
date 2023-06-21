// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//создаём функцию
int SumNumber()
{
    //записываем число для работы
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    //объявляем переменную для хранения суммы
    int sum = 0;
    //цикл, который записывает последее число в сумму и отбрасывает его от числа
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    //возвращаем значение
    return sum;
}

int enter = SumNumber();
Console.WriteLine(enter);