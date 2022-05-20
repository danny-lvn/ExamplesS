/*
Библиотека Linq - для работы с массивами
*/

using System;
using System.Linq;
using static System.Console;

Clear();

WriteLine("Enter array");
//           считали     разд. через пробел без нул. элем.            обрат. к кажд. и вз. с парс. и дел. масс.
//int[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
//int[] array1 = array.Select(x => x * -1).ToArray();
//int size = int.Parse(ReadLine());
int[] array2 = new int[int.Parse(ReadLine())].Select(x => new Random().Next(-9, 10)).ToArray();
//WriteLine(String.Join(" ", array));
//WriteLine(String.Join(" ", array1));
WriteLine(String.Join(" ", array2));