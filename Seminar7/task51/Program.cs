// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

const int ROWS = 3; // объявляем константы
const int COLUMNS = 4;

int[,] GetRandomMatrix(int rows, int columns) // метод создания массива с заданными параметрами
{
    int[,] matrix = new int[rows, columns]; // создание массива с нужным количеством строк и столбцов
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(0, 101); // заполняем значениями указанного диапазона
        }
    }

    return matrix; // вывод
}

void PrintMatrix(int[,] matrix) // вывод массива в консоль
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

int GetSum(int[,] matrix) // метод вывода суммы главной диагонали
{
    int sum = 0; // переменная для суммы
    int min = matrix.GetLength(0); // переменная для меньшего (столбцы или строки)
    if (matrix.GetLength(0) > matrix.GetLength(1))
    {
        min = matrix.GetLength(1);
    }
    for (int i = 0; i < min; i++) // подсчёт суммы
    {
        sum += matrix[i, i];
    }
    return sum; // возвращение значения
}

int[,] myArrow = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myArrow);
int mySum = GetSum(myArrow);
Console.WriteLine(mySum);