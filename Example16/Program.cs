// Написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами
// в случайном порядке.
// (Через метод)

using System;
using static System.Console;

Clear();
arr();

void arr()
{
    int[] r = new int[8];
    for (int i = 0; i < 8; i++)
    {
        r[i] = new Random().Next(2);
    }
WriteLine($"[{String.Join(",", r)}]");
}