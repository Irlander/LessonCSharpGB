// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04      00 01 02 03
// 12 13 14 05      10 11 12 13
// 11 16 15 06      20 21 22 23
// 10 09 08 07      30 31 32 33


const int ROWS = 4; // объявляем константы
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

void FillSpiralMatrix(int[,] matrix) // функция ввода значений в матрицу по спирали
{
    int movement = 0; // переменная напрвления (0 вправо, 1 вниз, 2 влево, 3 вверх)
    int xPosition = 0; // позиция индекса столбца в матрице для ввода значения
    int yPosition = 0; // позиция индекса строки в матрице для ввода значения
    int upLine = -1; // верхняя граница при передвижении
    int downLine = matrix.GetLength(0); // нижняя граница при передвижении
    int leftLine = -1; // левая граница при передвижении
    int rightLine = matrix.GetLength(1); // правая граница при передвижении
    for(int i = 0; i < matrix.Length; i++) // счётчик для ввода значений в матрицу
    {
        if(movement == 0 && xPosition < rightLine) // если движемся вправо и не упёрлись в границу
        {
            matrix[yPosition,xPosition] = i + 1; // вводим значение по заданному индексу
            xPosition++; // сдвигаем координату вправо
            if (xPosition == rightLine - 1 && yPosition == upLine + 1) // проверяем походимся ли в углу матрицы
            {
                movement = 1; // при нахождении в углу двигаемся вниз
                upLine++; // сдвигаем верхнюю границу
            }
        }
        else if(movement == 1 && yPosition < downLine) // если движемся вниз и не упёрлись в границу
        {
            matrix[yPosition,xPosition] = i + 1; // вводим значение по заданному индексу
            yPosition++; // сдвигаем координату вниз
            if (xPosition == rightLine - 1 && yPosition == downLine - 1) // проверяем походимся ли в углу матрицы
            {
                movement = 2; // при нахождении в углу двигаемся влево
                rightLine--; // сдвигаем правую границу
            }
        }
        else if(movement == 2 && xPosition > leftLine)
        {
            matrix[yPosition,xPosition] = i + 1; // вводим значение по заданному индексу
            xPosition--; // сдвигаем координату влево
            if (xPosition == leftLine + 1 && yPosition == downLine - 1) // проверяем походимся ли в углу матрицы
            {
                movement = 3; // при нахождении в углу двигаемся вверх
                downLine--; // сдвигаем нижнюю границу
            }
        }
        else if(movement == 3 && yPosition > upLine)
        {
            matrix[yPosition,xPosition] = i + 1; // вводим значение по заданному индексу
            yPosition--; // сдвигаем координату вверх
            if (xPosition == leftLine + 1 && yPosition == upLine + 1) // проверяем походимся ли в углу матрицы
            {
                movement = 0; // при нахождении в углу двигаемся вправо
                leftLine++; // сдвигаем левую границу
            }
        }
    }
}


int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS); // создаём пустую матрицу
FillSpiralMatrix(myMatrix); // заполняем значениями по спирали
PrintMatrix(myMatrix); // выводим в консоль