/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.
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
WriteLine();
PrintArray(SquareArray(GetArray(m, n)));

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

int[,] SquareArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i += 2)
	{
		for (int j = 0; j < array.GetLength(1); j += 2)
		{
			array[i, j] *= array[i, j];
		}
	}
	return array;
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