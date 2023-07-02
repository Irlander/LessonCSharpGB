// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

const int ROWS = 3; // объявляем константы
const int COLUMNS = 4;

double[,] GetRandomMatrix(int rows, int columns) // метод создания массива с заданными параметрами
{
    double[,] matrix = new double[rows, columns]; // создание массива с нужным количеством строк и столбцов
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(-10, 11) + Math.Round(Random.Shared.NextDouble(), 1); // заполнение значениями
        }
    }

    return matrix; // возвращение массива
}

void PrintMatrix(double[,] matrix) // метод вывода в консоль массива
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

double[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS); 
PrintMatrix(myMatrix);