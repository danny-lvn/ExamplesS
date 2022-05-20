/*
**Задача 37:** Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

using System;
using System.Linq;
using static System.Console;

Clear();

int[] array = new int[new Random().Next(1, 10)].Select(x => new Random().Next(0, 10)).ToArray();

switch (array.Length % 2)
{
	case 0:
	{
		int[] array1 = new int[array.Length / 2];
		for (int i = 0; i <= array.Length / 2 - 1; i++)
		{
			array1[i] = array[i] * array[array.Length - 1 - i];
		}
		WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", array1)}]");
        break;
	}
	case 1:
	{
		int[] array1 = new int[array.Length / 2 + 1];
		for (int i = 0; i <= array.Length / 2 - 1; i++)
		{
			array1[i] = array[i] * array[array.Length - 1 - i];
		}
		array1[array.Length / 2] = array[array.Length / 2];
		WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", array1)}]");
        break;
	}
}