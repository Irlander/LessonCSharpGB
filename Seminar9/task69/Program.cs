// Задача 69: Напишите программу, которая на вход принимает два
// числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число для возведения в степень");
int valueOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степени");
int valueTwo = Convert.ToInt32(Console.ReadLine());

int ToStepen (int valueOne, int valueTwo)
{
    if(valueTwo <= 0) return 1;
    return ToStepen (valueOne, valueTwo - 1) * valueOne;
}

int result = ToStepen(valueOne, valueTwo);
Console.WriteLine(result);