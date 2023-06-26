// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray()
{
    int[] array = new int[12];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }

    return array;
}

int SumPositiveElements(int[] massive)
{
    int sumOfPosEl = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            sumOfPosEl += massive[i];
        }
    }
    return sumOfPosEl;
}

int SumNegativeElements(int[] massive)
{
    int sumOfNegEl = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < 0)
        {
            sumOfNegEl += massive[i];
        }
    }
    return sumOfNegEl;
}

int[] myArray = GetRandomArray();
int sumPositive = SumPositiveElements(myArray);
int sumNegative = SumNegativeElements(myArray);

Console.WriteLine(string.Join(", ", myArray));
Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");