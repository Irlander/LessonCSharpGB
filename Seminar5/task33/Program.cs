// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [4, 7, 19, 345, 3] -> да
// 3; массив [6, 7, 19, 345, 3] -> нет

int[] GetRandomArray(int indexs)
{
    int[] array = new int[indexs];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-10, 11);
    }

    return array;
}

int[] myArray = GetRandomArray(8);
Console.WriteLine("Введите искомое число");
int findNumber = Convert.ToInt32(Console.ReadLine());
int temp = 0;
Console.Write(string.Join (", ", myArray));

for(int i = 0; i < myArray.Length; i++)
{
    if (findNumber == myArray[i])
    {
        temp = 1;
    }
}

if (temp == 0)
{
    Console.WriteLine(" - нет.");
}
else
{
    Console.WriteLine(" - да.");
}