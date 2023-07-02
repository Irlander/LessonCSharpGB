// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

const int ROWS = 3; // объявляем константы
const int COLUMNS = 4;

int[,] GetRandomMatrix(int rows, int columns) // функция создания массива с заданными параметрами
{
    int[,] matrix = new int[rows, columns]; // создание массива с нужным количеством строк и столбцов
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 101); // заполнение значениями
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

int enterNumber(string textToUser) // функция для ввода данных типа int с приглашением для пользователя. 
{
    Console.WriteLine(textToUser);
    int outText = Convert.ToInt32(Console.ReadLine());
    return outText;
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);  // создаём массив
PrintMatrix(myMatrix); // выводим массив
int searchRow = enterNumber("Введите индекс строки"); // создаём переменную и вводим данные для строчного индекса в массиве
int searchColumns = enterNumber("Введите индекс столбца"); // создаём переменную и вводим данные для индекса колонки в массиве

if (searchRow < myMatrix.GetLength(0) && searchColumns < myMatrix.GetLength(1)) // проверка на то, что есть ли в массиве значения под указанным индексом
{
    Console.WriteLine(myMatrix[searchRow, searchColumns]); // вывод значений
}
else
{
    Console.WriteLine("Такого числа в массиве нет"); // вывод исключения
}