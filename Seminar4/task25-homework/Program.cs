// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//объявляем функцию
int Square() 
{
    //ввод
    Console.WriteLine("Введите целое число:");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите целое число степени:");
    int level = Convert.ToInt32(Console.ReadLine());
    //добавляем переменную для корня
    int multiplier = number;
    //цикл, который умножаем заданное число само на себя указанное количество раз
    while (level > 1)
    {
        number = number * multiplier;
        level--;
    }
    //возвращаем число
    return number;
}
int enter = Square();
Console.WriteLine(enter);