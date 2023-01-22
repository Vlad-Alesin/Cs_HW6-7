/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
            Console.Write($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}

//метод для инициализации массива рандомными числами
int[,] InitArray(int row, int column)
{
    int[,] result = new int[row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(1,100);
        }
    }
    return result;
} 

void Average(int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        float count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            count += matrix[i,j];
        }
        if (j == matrix.GetLength(0)-1) Console.Write($"{count/matrix.GetLength(0)}.");
        else Console.Write($"{count/matrix.GetLength(0)}; ");
    }
}

Console.WriteLine("Укажите границы матрицы");
int m = GetNumber("введите количество строк");
int n = GetNumber("введите количество столбцов");
int[,] matrix = InitArray(m, n);
PrintArray(matrix);
Console.WriteLine();
Average(matrix);
