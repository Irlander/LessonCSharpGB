// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных. Элементы [0, 9]

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

void PrintArray(int[] array) // метод вывода в консоль массива
{
    for(int i = 0; i < array.Length; i++) // перебор столбцов
    {
            Console.Write($"|{i} : {array[i]}|\t"); // вывод
    }
}

int[] FrequncyArray (int[,] matrix) // функция подсчёта значений в матрице
{
    int[] outArray = new int[10]; // создание массива с индексами равными значениям матрицы

    for(int i = 0; i < matrix.GetLength(0); i++) // перебор строк
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // перебор столбцов
        {
            outArray[matrix[i, j]]++; // добавление 1 к нужному индексу
        }
    }
    return outArray; // вывод массива
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);  // создаём матрицу
PrintMatrix(myMatrix);  // выводим матрицу
int[] myArray = FrequncyArray(myMatrix);  // создаём и заполняем частотный словарь
Console.WriteLine();  // отступ
PrintArray(myArray);  // вывод частотного словаря
