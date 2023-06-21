// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt()
{
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ProizFrom1toN(int a)
{
    int proiz = 1;
    for (int i = 1; i <= a; i++)
    {
        proiz = proiz * i;
    }
    return proiz;
}

int number = ReadInt();
int pQuality = ProizFrom1toN(number);
Console.WriteLine ($"Произведение цифр равно {pQuality}");