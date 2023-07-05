// Задача 59: Задайте двумерный массив из целых
// чисел. Напишите программу, которая удалит строку и
// столбец, на пересечении которых расположен
// наименьший элемент массива.

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

int[] DeletingCoordinates(int[,] matrix) // функция получения массива с координатами минимального значения в матрице
{
    int minRow = 0; // переменная с координатой строки с минимальным значением
    int minColumns = 0; // переменная с координатой столбца с минимальным значением
    int min = matrix[0,0]; // переменная с минимальным значением

    for(int i = 0; i < matrix.GetLength(0); i++) // перебор строк
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // перебор столбцов
        {
            if (min > matrix[i,j]) // условие записи в min минимального значения и координат
            {
                min = matrix[i,j];
                minRow = i;
                minColumns = j;
            }
        }
    }
    int[] deletingCoordinates = new int[] {minRow, minColumns};  //  создание массива с координатами
    return deletingCoordinates; // вывод массива
    //return new int[] {minRow, minColumns};
}

int[,] EditMatrix(int[,] matrix, int[] array) // функция вывода исправленной матрицы
{
    int[,] editMatrix = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1]; // создаём новую матрицу меньшего размера

    for(int i = 0; i < editMatrix.GetLength(0); i++) // перебор строк
    {
        int shiftRow = 0; // переменная для хранения сдвига строк на 1 (выступает флагом), сброс в цикле
        int shiftColumns = 0; // переменная для хранения сдвига столбцов на 1 (выступает флагом), сброс в цикле

        if(i == array[0] || shiftRow == 1) // условие для установки сдвига строк и сброс сдвига столбцов
        {
            shiftRow = 1;
        }
        for(int j = 0; j < editMatrix.GetLength(1); j++) // перебор столбцов
        {
            if(j == array[1] || shiftColumns == 1) // условие для установки сдвига столбцов
            {
                shiftColumns = 1;
            }
            editMatrix[i,j] = matrix[i+shiftRow, j+shiftColumns]; // присвоение значения из исходной матрицы с учётом сдвига
        }
    }
    return editMatrix; // вывод исправленой матрицы
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS); // создаём новую матрицу
PrintMatrix(myMatrix); // выводим матрицу
int[] myArray = DeletingCoordinates(myMatrix); // получаем координаты наименьшего значения в матрице
Console.WriteLine(); // отступ
Console.WriteLine($"{String.Join(", ", myArray)}"); // выводим координаты наименьшего значения
int[,] myEditMatrix = EditMatrix(myMatrix, myArray); // получаем новую матрицу без строк и столбцов с наименьшим значением
Console.WriteLine(); // отступ
PrintMatrix(myEditMatrix); // выводим новую матрицу