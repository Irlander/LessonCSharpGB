// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//объявляем массив
int[] array = new int [8];
//цикл с заполнением данными
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите целое число для ячейки с индексом {i} в массиве");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
//вывод информации
Console.WriteLine($"Массив заполнен: {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}");