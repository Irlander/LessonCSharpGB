// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

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

int[,] MultiplyMatrix(int[,] matrixOne, int[,] matrixTwo) // функция перемножения матриц
{
    int[,] multiplyMatrix = new int[matrixOne.GetLength(0),matrixOne.GetLength(1)]; // создаём новую матрицу

    for(int i = 0; i < matrixOne.GetLength(0); i++) // перебор строк
    {
        for(int j = 0; j < matrixOne.GetLength(1); j++) // перебор столбцов
        {
            multiplyMatrix[i, j] = matrixOne[i, j] * matrixTwo[i, j]; // перемножаем значения по индексам в матрицах
        }
    }
    return multiplyMatrix; // вывод
}

int[,] myMatrixOne = GetRandomMatrix(ROWS,COLUMNS); // создаём первую матрицу
int[,] myMatrixTwo = GetRandomMatrix(ROWS,COLUMNS); // создаём вторую матрицу
PrintMatrix(myMatrixOne); // вывод первой матрицу
Console.WriteLine(); // отступ
PrintMatrix(myMatrixTwo); // вывод вторую матрицу
Console.WriteLine(); // отступ
int[,] myMultiplyMatrix = MultiplyMatrix(myMatrixOne, myMatrixTwo); // перемножаем значения
PrintMatrix(myMultiplyMatrix); // вывод