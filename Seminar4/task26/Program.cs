// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Quality(int a)
{
    int Colvo = 0;
    while (a > 0)
    {
        a = a / 10;
        Colvo++;
    }
    return Colvo;
}

int number = ReadInt();
int pQuality = Quality(number);
Console.WriteLine ($"Количество цифр равно {pQuality}");