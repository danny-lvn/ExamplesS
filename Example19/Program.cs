/*
**Задача 33:** Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

using System;
using static System.Console;

Clear();

int[] array = GetArray(12, -9, 9);
WriteLine(String.Join(" ", array));
WriteLine(NiA(4, array));
WriteLine(NiA2(4, array) ? "Yes" : "No");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

string NiA(int num, int[] array)
{
    string res = "No";
    foreach (int el in array)
    {
        if (el == num)
        {
            res = "Yes";
            break;
        }
    }
    return res;
}

bool NiA2(int num, int[] array)
{
    foreach (int el in array)
    {
        if (el == num)
        {
            return true;
        }
    }
    return false;
}