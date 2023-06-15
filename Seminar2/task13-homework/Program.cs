// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number; //переменная для временного хранения различных значений переменных
int i = 0;

while (temp != 0) //считаем количество порядков
{
    temp = temp / 10;
    i++;
}
if (i > 2)
{
while (i != 3)
{
    number = number / 10;
    i--;
}
number = number % 10;
Console.WriteLine($"Третьей цифрой числа является {number}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}