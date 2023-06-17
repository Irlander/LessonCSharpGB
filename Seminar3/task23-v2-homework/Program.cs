// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");     //ввод данных
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)     //циклом считаем кубы от 1 до N и выводи в консоль
{
    Console.WriteLine(Math.Pow(i, 3));
}