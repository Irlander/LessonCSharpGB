// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else if (day < 6)
{
    Console.WriteLine("Будний день");
}