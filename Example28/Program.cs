/*
Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.
*/

using System;
using System.Linq;
using static System.Console;

Clear();

int[] Array = new int[new Random().Next(1, 11)].Select(x => x = new Random().Next(-99, 100)).ToArray();
WriteLine(String.Join(" ", Array));
WriteLine((String.Join(" ", copyArray(Array))));

int[] copyArray(int[] array)
    {
    int[] Array1 = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
        {
            Array1[i] = Array[i];
        }
        return Array1;
    }