// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M"); // вводим данные
int valueM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int valueN = Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int numberM, int numberN) // функция Аккермана
{
    if (numberM == 0) // возвращаем N + 1 если M равен 0
    {
        return numberN + 1;
    }
    else if (numberN == 0) // возвращаем int равный (M - 1, 1), если N равен 0
    {
        return AckermannFunction (numberM - 1, 1);
    }
    else // возвращаем int по формуле, если M и N больше 0
    {
        return AckermannFunction (numberM - 1, AckermannFunction (numberM, numberN - 1));
    }
}

int result = AckermannFunction(valueM, valueN); // создаём переменную для результата функции
Console.WriteLine(result); // вывод