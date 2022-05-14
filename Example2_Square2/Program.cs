// Второе число квадрат первого числа?

using System;
using static System.Console;

WriteLine("Input the first number");
int n1 = Convert.ToInt32(ReadLine());
WriteLine("Input the second number");
int n2 = Convert.ToInt32(ReadLine());
if (n2 == n1 * n1)
{
    WriteLine($"{n1} IS A SQUARE of {n2}");
}
else
{
    WriteLine($"{n1} ISN'T A SQUARE of {n2}");
}