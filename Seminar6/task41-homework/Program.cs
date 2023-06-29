// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество вводимых чисел"); //ввод 
int arrayLenght = Convert.ToInt32(Console.ReadLine()); //переменная для длины массива
int sum = 0; //переменная для подсчёта положительных чисел
int[] array = new int[arrayLenght];  //создаём массив

for(int i = 0; i < arrayLenght; i++)  //заполняем массив значениями
{
    Console.WriteLine($"Введите число для индекса {i}:");  //ввод
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for(int i = 0; i < arrayLenght; i++)  //проверка и подсчёт на положительные числа
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество положительных чисел равно {sum}:");  //вывод