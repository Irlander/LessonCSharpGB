// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число"); // ввод числа
int value = Convert.ToInt32(Console.ReadLine());

void NaturalNumber (int number, int max) // функция для рекурсивного вычисления от N до 1
{
    if (number <= 0) return; // условие выхода
    NaturalNumber (number - 1, max); // новая итерация с уменьшением значения
    Console.Write($"{max-number+1} "); // вывод в консоль
}

NaturalNumber(value, value); // вызываем функцию