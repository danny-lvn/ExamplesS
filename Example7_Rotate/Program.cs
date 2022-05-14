// Обратное значение числа

using System;
using static System.Console;

WriteLine("Enter a number");
float n = Convert.ToInt32(ReadLine());
if (n != 0)
{
    n = 1 / n;
}
WriteLine(n);