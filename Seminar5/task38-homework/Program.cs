// Задача 38: Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 12, 2, 78] => 76

int[] GetRandomArray() // функция для создания массива случайного размера
{
    int indexs = Random.Shared.Next(4, 9);
    int[] array = new int[indexs]; //создание массива со случайными числами от 1 до 100
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(1, 101);
    }

    return array; //возвращение массива
}

int diff(int[] array) // функция для получения макс и мин значения + их расности
{
    int max = array[0]; // переменная для макс
    int min = array[0]; // переменная для мин
    for(int i = 1; i < array.Length; i++)  // циклом записываем макс и мин значения сравнивая поочерёдно значения в массиве поочрёдно
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    max = max - min;  // перезаписываем в переменную макс разницу между макс и мин
    return max; // возвращаем разницу
    // P.S. сохраняю в макс, чтобы не создавать новую переменную. Экономия памяти)
}

int[] myArray = GetRandomArray();
int diffMaxMin = diff(myArray);

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива [ {string.Join(", ", myArray)} ] составляет {diffMaxMin}");