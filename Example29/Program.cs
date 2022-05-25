/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
Amn = m + n. Выведите полученный массив на экран.
*/

using System;
using System.Linq;
using static System.Console;

Clear();

WriteLine("Enter count of rows");
int m = Convert.ToInt32(ReadLine());
WriteLine("Enter count of columns");
int n = Convert.ToInt32(ReadLine());

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