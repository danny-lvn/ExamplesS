/*
Задача 59: Из двумерного массива целых чисел удалить строку и столбец,
на пересечении которых расположен наименьший элемент.
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
int[] Coordinates = GetMin(Matrix);
WriteLine(String.Join(" ", Coordinates));
WriteLine();
int[,] NewMatrix = GetNewMatrix(Coordinates, Matrix);
PrintMatrix(NewMatrix);

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

int[] GetMin(int[,] matrix)
{
    int[] result = {0, 0};
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] GetNewMatrix(int[] coord, int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == coord[0]) continue;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == coord[1]) continue;
            result[row, column] = matrix[i, j];
            column++;
        }
        column = 0;
        row++;
    }
    return result;
}