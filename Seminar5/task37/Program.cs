// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetRandomArray(int indexs)
{
    int[] array = new int[indexs];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-10, 11);
    }

    return array;
}

int[] SumOfIndex(int[] array)
{
    int[] halfarray = new int[(array.Length + 1) / 2];
    for (int i = 0; i < halfarray.Length; i++)
    {
        halfarray[i] = array[i] * array[array.Length - 1 - i];
    }
    if(array.Length % 2 == 1)
    {
        halfarray[halfarray.Length - 1] = Convert.ToInt32(Math.Sqrt(halfarray[halfarray.Length - 1]));
    }
    return halfarray;
}

Console.WriteLine("Введите количество индексов в массиве");
int index = Convert.ToInt32(Console.ReadLine());
int[] myArray = GetRandomArray(index);
Console.WriteLine(string.Join(", ", myArray));
int[] resultArray = SumOfIndex(myArray);
Console.WriteLine($"Произведение пар чисел в одномерном массиве равно {string.Join(", ", resultArray)}");