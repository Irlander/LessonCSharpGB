// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

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

float[] MediumArif(int[,] matrix) // функция создания одномерного массива со средним арифметическим
{
    float[] array = new float[matrix.GetLength(1)]; // создание массива для хранения значений
    for(int j = 0; j < matrix.GetLength(1); j++) // перебор столбцов
    {
        float sum = 0; // переменная для хранения суммы в столбце
        for(int i = 0; i < matrix.GetLength(0); i++) // перебор значений в строке
        {
            sum += matrix[i, j]; // подсчёт суммы в столбце
        }
        array[j] = sum / matrix.GetLength(0); // подсчёт среднего арифметического в стобце
    }
    return array; // вывод массива со значениями
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS); // создание массива
PrintMatrix(myMatrix); // вывод массива в консоль
float[] myArray = MediumArif(myMatrix); // получение массива с данными среднего арифметического
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join(", ", myArray)}"); // вывод в консоль
