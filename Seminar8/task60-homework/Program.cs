// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


const int BLOCK = 2; // объявляем константы
const int ROWS = 2;
const int COLUMNS = 2;

int[,,] GetRandomMatrix( int block, int rows, int columns) // функция создания массива с заданными параметрами
{
    int[,,] matrix = new int[block, rows, columns]; // создание массива с нужным количеством блоков, строк и столбцов
    int shift = 2;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = Random.Shared.Next(1, 10) + shift; // заполнение значениями
                shift = matrix[i, j, k];
            }
        }
    }
    return matrix; // возвращение массива
}

void PrintMatrix(int[,,] matrix) // функция вывода в консоль массива
{
    for(int i = 0; i < matrix.GetLength(0); i++) // вывод блоков
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // вывод строк
        {
            for(int k = 0; k < matrix.GetLength(2); k++) // вывод столбцов
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] myMatrix = GetRandomMatrix(BLOCK, ROWS, COLUMNS);  // создание многомерного массива
PrintMatrix(myMatrix); // вывод массива в консоль