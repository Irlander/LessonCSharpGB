// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray() // функция для создания массива случайного размера
{
    int indexs = Random.Shared.Next(4, 9);
    int[] array = new int[indexs]; //создание массива со случайными числами от -100 до 100
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-100, 101);
    }

    return array; //возвращение массива
}

int GetSumNegativePosition(int[] array) // функция для полученифя суммы элементов, стоящих на нечётных позициях
{
    int sum = 0; // переменная для суммы
    for (int i = 1; i < array.Length; i = i + 2)  // счётчик нечётных позиций
    {
        sum = sum + array[i];
    }
    return sum; // вывод
}

int[] myArray = GetRandomArray();
int sumNegativeArray = GetSumNegativePosition(myArray);
Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях в массиве [ {string.Join(", ", myArray)} ] равна {sumNegativeArray}");