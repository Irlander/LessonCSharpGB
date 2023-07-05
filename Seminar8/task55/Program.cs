// Задача 55: Задайте двумерный массив. Напишите
// программу, которая заменяет строки на столбцы.


const int ROWS = 3; // объявляем константы
const int COLUMNS = 4;

int[,] GetRandomMatrix(int rows, int columns) // метод создания массива с заданными параметрами
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

void PrintMatrix(int[,] matrix) // метод вывода в консоль массива
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

int[,] RotateMatrix(int[,] matrix)
{
    int[,] rotateMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            rotateMatrix[j, i] = matrix[i, j];
        }
    }
    return rotateMatrix;
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS); 
PrintMatrix(myMatrix);
int[,] myArray = RotateMatrix(myMatrix);
PrintMatrix(myArray);