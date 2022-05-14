// Модуль числа

using System;
using static System.Console;

WriteLine("Enter a number");
int n = Convert.ToInt32(ReadLine());
int N = n;
if (n < 0)
{
    N = n * (-1);
}
WriteLine($"{N} is a module of the {n}");