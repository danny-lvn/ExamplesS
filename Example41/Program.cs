/*
**Задача 70:** Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел,
для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

using System;
using static System.Console;

Clear();

WriteLine("Enter two first numbers and count of next numbers");
int[] Numbers = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

Write($"{Numbers[0]} {Numbers[1]} ");
WriteLine(Furie(Numbers[0], Numbers[1], Numbers[2] - 2));

string Furie(int start, int end, int length)
{
    return length == 0 ? " ": start + end + " " + Furie(end, start + end, length - 1);
}