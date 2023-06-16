// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int part = Convert.ToInt32(Console.ReadLine());

if (part == 1)
{
 Console.WriteLine("x>1, y>1");
}
else if (part == 2)
{
 Console.WriteLine("x<1, y>1");
}
else if (part == 3)
{
 Console.WriteLine("x<1, y<1");
}
else if (part == 4)
{
 Console.WriteLine("x>1, y<1");
}
else
{
 Console.WriteLine("Такой области нет");
}