// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите длину первой стороны:"); //ввод сторон
int edgeOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны:");
int edgeTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны:");
int edgeThree = Convert.ToInt32(Console.ReadLine());

// проверка условия, что сумма любых двух строн больше одной стороны
if (edgeOne < edgeTwo + edgeThree && edgeTwo < edgeOne + edgeThree && edgeThree < edgeTwo + edgeOne)
{
    Console.WriteLine("Треугольник с такими сторонами может существовать.");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами не может существовать.");
}