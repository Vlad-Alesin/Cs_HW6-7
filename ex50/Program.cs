/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */


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

void FindNumber(int [,] matrix, int row, int column)
{
    if (row <= matrix.GetLength(0) && column <= matrix.GetLength(1)) Console.WriteLine(matrix[row-1, column-1]);
    else Console.WriteLine("такого числа в массиве нет");
}

Console.WriteLine("Укажите границы матрицы");
int m = GetNumber("введите количество строк");
int n = GetNumber("введите количество столбцов");

int[,] matrix = InitArray(m, n);
PrintArray(matrix);
Console.WriteLine();

int q = GetNumber("введите строку элемента");
int e = GetNumber("введите столбец элемента");
FindNumber(matrix, q, e);
