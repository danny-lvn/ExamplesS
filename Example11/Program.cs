/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

using System;
using static System.Console;

Clear();

WriteLine("Enter N");
int N = Convert.ToInt32(ReadLine());
int i = 1;
while (i <= N)
{
    Write(Math.Pow(i, 2));
    i++;
}