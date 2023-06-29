// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите угловой коэффициент первой прямой"); //вводим данные
int coeffFirstLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку пересечения с осью Y первой прямой");
int crossfFirstLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент второй прямой");
int coeffSecondLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку пересечения с осью Y второй прямой");
int crossfSecondLine = Convert.ToInt32(Console.ReadLine());

// считаем координату пересечения х по формуле
double xCoordinate = (Convert.ToDouble(crossfSecondLine) - Convert.ToDouble(crossfFirstLine)) / 
                     (Convert.ToDouble(coeffFirstLine) - Convert.ToDouble(coeffSecondLine));

// считаем координату пересечения у по формуле
double yCoordinate = Convert.ToDouble(coeffFirstLine) * xCoordinate + Convert.ToDouble(crossfFirstLine);

Console.WriteLine($"Координаты точки пересечения: {xCoordinate}, {yCoordinate}"); // вывод