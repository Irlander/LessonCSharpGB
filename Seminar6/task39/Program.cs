// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int index, int leftRange, int rightRange) // функция получения массива
{
    int[] array = new int[index];  //создаём новый массив с длиной равной index

    for (int i = 0; i < array.Length; i++)  // цикл заполняет массив случайными  значениями от leftRange до rightRange + 1
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array; //возвращение массива
}

void ReverseArray(int[] array) //функция изменения массива (void возвращает то, что было на входе)
{
    for (int i = 0; i < array.Length / 2; i++) //цикл, который перебирает все индексы до середины и меняет их местами со значениями с конца
    {
        int temp = array[i];  //временная переменная
        array[i] = array[array.Length - 1 - i]; //переписываем значение индекса с конца в начало
        array[array.Length - 1 - i] = temp; //переписываем значение из темпа в конец
    }
}

int[] myArray = GetRandomArray(8, -10, 10);  //создание массива с указанными параметрами
Console.WriteLine(string.Join(", ", myArray)); //вывод изначального массива
ReverseArray(myArray); //разворот массива
Console.WriteLine(string.Join(", ", myArray)); //вывод изменённого массива
