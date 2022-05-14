// Последняя цифра трехзначного числа

using System;
using static System.Console;

WriteLine("Enter a number");
int n = Convert.ToInt32(ReadLine());
int N = n%10;
WriteLine($"The last digit of {n} is {N}");