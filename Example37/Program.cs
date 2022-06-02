/*
**Задача 65:** Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

using System;
using static System.Console;

Clear();

WriteLine("Enter numbers M and N");
int[] MatrixSize = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
string result = GetNumbers(MatrixSize[0], MatrixSize[1]);
WriteLine(result);

static string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + GetNumbers(start + 1, end));
}