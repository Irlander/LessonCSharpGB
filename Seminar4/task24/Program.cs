// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt() //создаём метод для ввода числа
{
    Console.WriteLine("Введите целое число:");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumFrom1toN(int a) //создаём метод для получения суммы
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int number = ReadInt(); 
int Summa = SumFrom1toN(number);
Console.WriteLine(Summa);