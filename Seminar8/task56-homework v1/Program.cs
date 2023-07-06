// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


const int ROWS = 3; // объявляем константы
const int COLUMNS = 4;

int[,] GetRandomMatrix(int rows, int columns) // функция создания массива с заданными параметрами
{
    int[,] matrix = new int[rows, columns]; // создание массива с нужным количеством строк и столбцов
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10); // заполнение значениями
        }
    }

    return matrix; // возвращение массива
}

void PrintMatrix(int[,] matrix) // функция вывода в консоль массива
{
    for(int i = 0; i < matrix.GetLength(0); i++) // вывод строк
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // вывод столбцов
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] SumMatrixRow(int[,] matrix) // функция получения сумм строк
{
    int[] outArray = new int[matrix.GetLength(0)]; // создаём массив, который будет хранить суммы строк - индекс равен индексу строки  матрице на входе
    for(int i = 0; i < matrix.GetLength(0); i++) // счётчик строк
    {
        int sum = 0; // переменная для хранения суммы, инициализирована здесь для сброса при переходе на новую строку
        for(int j = 0; j < matrix.GetLength(1); j++) // счётчик столбцов
        {
            sum = sum + matrix[i, j]; // подсчёт суммы значений в строке
        }
        outArray[i] = sum; // запись суммы в массив
    }
    return outArray; // вывод массива с суммами
}

int GetMinRowArray(int[] array) // функция получения индекса с минимальным числом в массиве
{
    int min = 0; // переменная для хранения минимального индекса, по умолчанию 0

    for(int i = 1; i < array.Length; i++) // циклом перебираем все значения по индексам с 1 по последний
    {
        if(array[min] > array[i]) // проверяем что индекс с мин значением больше значения в указанном индексе
        {
            min = i; // присваиваем индекс минимального значения переменной min
        }
    }
    return min; // вывод
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS); // создаём массив
PrintMatrix(myMatrix); // выводим массив
Console.WriteLine(); // отступ
int[] myArray = SumMatrixRow(myMatrix); // получаем суммы всех строк
int minSumRow = GetMinRowArray(myArray); // узнаём строку с минимальным значением
Console.WriteLine($"{minSumRow + 1} строка"); // выводим в формате строки с поправкой для пользователя