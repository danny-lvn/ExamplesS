/*
**Задача 69:** Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

using System;
using static System.Console;

Clear();

WriteLine("Enter numbers A and B");
int[] MatrixSize = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
WriteLine(GetDegree(MatrixSize[0], MatrixSize[1]));

int GetDegree(int a, int b)
{
    if (b == 1) return a;
    return (a *= GetDegree(a, b - 1));
}