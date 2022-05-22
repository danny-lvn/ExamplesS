/*
**Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
**Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.
*/

using System;
using System.Linq;
using static System.Console;

Clear();

WriteLine("Enter three numbers in format: a b c");
int[] ar = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
WriteLine(ar[0] < ar[1] + ar[2] && ar[1] < ar[0] + ar[2] && ar[2] < ar[0] + ar[1] ? "Yes" : "No");