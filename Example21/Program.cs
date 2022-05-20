/*
**Задача 35:** Задайте одномерный массив из 123 случайных чисел [0, 1000].
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

using System;
using System.Linq;
using static System.Console;

Clear();

int[] array = new int[123].Select(x => new Random().Next(0, 1000)).ToArray();
int count = 0;
foreach (int el in array)
{
	count += (el >= 10 && el <= 99) ? 1 : 0;
}
WriteLine(String.Join(" ", array));
WriteLine(count);


/*2 вариант через метод
int[] array = new int[123].Select(x => new Random().Next(0, 1000)).ToArray();
WriteLine(String.Join(" ", array));
WriteLine(meth(array, 10, 99));

int meth(int[] array, int minValue, int maxValue)
{
	int count = 0;
	foreach (int el in array)
	{
		count += ((el >= minValue) && (el <= maxValue)) ? 1 : 0;
	}
	return count;
}
*/