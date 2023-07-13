// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число"); // вводим данные
int valueOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int valueTwo = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumber (int numberOne, int numberTwo) // функция подсчёта суммы всех цифр от numberOne до numberTwo
{
    if (numberOne == numberTwo) return numberTwo; // условия выхода
    numberOne = numberOne + SumNaturalNumber (numberOne + 1, numberTwo); // считаем сумму в числе numberOne
    return numberOne; // возвращаем значение
}

if(valueOne > valueTwo) // обрабатываем условие когда первое число больше второго (переворачиваем)
{
    int temp = valueOne;
    valueOne = valueTwo;
    valueTwo = temp;
}

int result = SumNaturalNumber(valueOne, valueTwo); // считаем суммы в переменную с помощью функции
Console.WriteLine(result); // вывод