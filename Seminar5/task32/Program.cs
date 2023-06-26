// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetRandomArray(int indexs)
{
    int[] array = new int[indexs];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-100, 101);
    }

    return array;
}

int[] myArray = GetRandomArray(10);
Console.WriteLine("Изначальный массив");
Console.WriteLine(string.Join (", ", myArray));
for(int i = 0; i < myArray.Length; i++)
    {
    myArray[i] = -myArray[i];
    }
Console.WriteLine("Инвертированный массив");
Console.WriteLine(string.Join (", ", myArray));