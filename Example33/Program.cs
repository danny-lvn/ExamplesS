/*
**Задача 55:** Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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
if (Matrix.GetLength(0) == Matrix.GetLength(1))
{
    int[,] NewMatrix = ReverseMatrix(Matrix);
    PrintMatrix(NewMatrix);
}
else WriteLine("I can't reverse this matrix");


int[,] GetMatrix(int row, int column)
{
	int[,] result = new int[row, column];
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; j < column; j++)
		{
			result[i, j] = new Random().Next(1, 10);
		}
	}
	return result;
}

int[,] ReverseMatrix(int[,] matrix)
{
    int bubble;
    for (int m = 0; m < matrix.GetLength(1) - 1; m++)
        for (int n = m + 1; n < matrix.GetLength(1); n++)
        {
            bubble = matrix[m, n];
            matrix[m, n] = matrix[n, m];
            matrix[n, m] = bubble;
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