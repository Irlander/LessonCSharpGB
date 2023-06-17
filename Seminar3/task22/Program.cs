// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 2));
    if (i != number)
    {
        Console.Write(", ");
    }
}