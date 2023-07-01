// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

const int ROWS = 3; // объявляем константы
const int COLUMNS = 4;

int[,] GetRandomMatrix(int rows, int columns) // метод создания массива с заданными параметрами
{
    int[,] matrix = new int[rows, columns]; // создание массива с нужным количеством строк и столбцов
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(-10, 11);
        }
    }

    return matrix; // вывод
}

void PrintMatrixEdit(int[,] matrix) // метод вывода в консоль массива
{
    for(int i = 0; i < matrix.GetLength(0); i++) // вывод строк
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // вывод столбцов
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0) // если позиция по виду чётная, то возводим в квадрат
            {
                Console.Write($"{matrix[i, j] * matrix[i, j]}\t"); 
            }
            else
            {
                Console.Write($"{matrix[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,] matrix) // метод вывода в консоль массива без изменения
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

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS); 
PrintMatrix(myMatrix);
Console.WriteLine();
PrintMatrixEdit(myMatrix);