// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координату первой точки по оси x");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по оси y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по оси x");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по оси y");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(result);