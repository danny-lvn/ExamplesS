/*
**Задача 32:** Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

using System;
using static System.Console;

Clear();

int[] array = GetArray(12, -9, 9);
WriteLine(String.Join(" ", array));
int[] newArray = GetNewArray(array);
WriteLine(String.Join(" ", newArray));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] GetNewArray(int[] oldArray)
{
    for (int i = 0; i < oldArray.Length; i++)
    {
        oldArray[i] *= (-1);
    }
    return oldArray;
}