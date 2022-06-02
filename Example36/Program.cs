/*
**Задача 63:** Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

using System;
using static System.Console;

Clear();
int N = 5;

string result = GetNumbers(1, N);
WriteLine(result);

static string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + GetNumbers(start + 1, end));
}