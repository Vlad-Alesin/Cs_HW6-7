/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

double[,] FillArray(int row, int column)
{
    Random x = new Random();
    double[,] array = new double[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double r = Convert.ToDouble(x.Next(-100, 100)/10.0);
            array[i,j] = r;
        }
    }
    return array;
}

void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("введите количество строк");
int n = GetNumber("введите количество столбцов");

double[,] matrix = FillArray(m, n);
PrintArray(matrix);
