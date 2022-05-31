/*
**Задача 57:** Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

using System;
using System.Linq;
using static System.Console;

Clear();

WriteLine("Enter count of  rows and columns");
int[] MatrixSize = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] Matrix = GetMatrix(MatrixSize[0], MatrixSize[1]);
int[] Expand = ExpandMatrix(Matrix);
WriteLine();
PrintMatrix(Matrix);
WriteLine();
WriteLine(String.Join(" ", Expand));
int[] SortExpand = SortExpandMatrix(Expand);
WriteLine();
WriteLine(String.Join(" ", SortExpand));
WriteLine();
Dict(SortExpand);


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

int[] ExpandMatrix(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[n] = matrix[i, j];
            n++;
        }
    }
    return array;
}

int[] SortExpandMatrix(int[] exmatr)
{
    for (int i = 0; i < exmatr.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < exmatr.Length; j++)
        {
            if (exmatr[j] < exmatr[minPosition]) minPosition = j;
        }
        int temporary = exmatr[i];
        exmatr[i] = exmatr[minPosition];
        exmatr[minPosition] = temporary;
    }
    return exmatr;
}

void Dict(int[] array)
{
    int count = 1;
    int i = 1;
    int num = array[0];
    while (i < array.Length)
    {
        if (array[i] == num)
        {
            count++;
            i++;
        }
        else
        {
            WriteLine($"{num} - {count} ends");
            num = array[i];
            count = 1;
            i++;
        }
    }
    WriteLine($"{num} - {count} ends");
}