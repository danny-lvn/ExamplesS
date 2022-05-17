// Напишите программу, которая принмиает на вход число A, и выдает сумму чисел от 1 до A.
// (В виде отдельного метода)

using System;
using static System.Console;

Clear();

WriteLine("Enter A");
WriteLine(sum(Convert.ToInt32(ReadLine())));

int sum (int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++) sum += i;
    return sum;
}