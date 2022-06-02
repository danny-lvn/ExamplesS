/*
**Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

using System;
using static System.Console;

Clear();

WriteLine("Enter a number");
int Number = Convert.ToInt32(ReadLine());
WriteLine(GetSumOfDigit(Number));

int GetSumOfDigit(int num)
{
    if (num == 0) return num;
    return (num % 10 + GetSumOfDigit(num / 10));
}