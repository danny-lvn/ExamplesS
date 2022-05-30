/*
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/

using System;
using System.Linq;
using static System.Console;

Clear();

WriteLine("Enter count of  rows and columns");
int[] MatrixSize = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] Matrix = GetMatrix(MatrixSize[0], MatrixSize[1]);
PrintMatrix(Matrix);
WriteLine();
int[,] NewMatrix = GetNewMatrix(Matrix);
PrintMatrix(NewMatrix);

int[,] GetMatrix(int row, int column)
{
	int[,] result = new int[row, column];
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < column; j++)
		{
			result[i, j] = new Random().Next(10, 100);
		}
	}
	return result;
}

int[,] GetNewMatrix(int[,] matrix)
{
    int bubble;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        bubble = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = matrix[0, j];
        matrix[0, j] = bubble;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Write($"{matrix[i, j]} ");
		}
		WriteLine();
	}
}