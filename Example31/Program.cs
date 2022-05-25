/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
(с индексами (0,0); (1;1) и т.д.
*/

using System;
using System.Linq;
using static System.Console;

Clear();

WriteLine("Enter count of rows");
int m = Convert.ToInt32(ReadLine());
WriteLine("Enter count of columns");
int n = Convert.ToInt32(ReadLine());

WriteLine($"{SumMainD(GetArray(m, n))} is the sum of elements in main diagonale in array");
PrintArray(GetArray(m, n));

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

int SumMainD(int[,] array)
{
    int result = 0;
    int a = (array.GetLength(0) >= array.GetLength(1)) ? array.GetLength(1) : array.GetLength(0);
        for (int n = 0; n < a; n++)
        {
            result += array[n, n];
        }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}