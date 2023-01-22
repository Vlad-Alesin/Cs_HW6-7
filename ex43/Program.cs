/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

float GetNumber(string message)
{
    float result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(float.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("ввели не число");
        }
    }

    return result;
}

(float, float) koord(float k1, float b1, float k2, float b2)
{
    float X = (b2-b1)/(k1-k2);
    float Y = k1*X + b1;
    Console.WriteLine($"координаты точки пересечения ({X}, {Y})");
    return (X, Y);
}


Console.WriteLine("Введите коэффициенты линейных уравнений");
float k1 = GetNumber("Введите коэффициент k1");
float b1 = GetNumber("Введите коэффициент b1");
float k2 = GetNumber("Введите коэффициент k2");
float b2 = GetNumber("Введите коэффициент b2");
koord (k1, b1, k2, b2);