// Написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами
// в случайном порядке.
// (Через метод)

using System;
using static System.Console;

Clear();

WriteLine("Enter a length of array");
int l = Convert.ToInt32(ReadLine());
arr(l);

void arr(int l)
{
    int[] r = new int[l];
    for (int i = 0; i < l; i++)
    {
        r[i] = new Random().Next(2);
    }
WriteLine($"[{String.Join(",", r)}]");
}