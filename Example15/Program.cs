// Напишите программу, которая принимиает на вход число N, и выдает произведение чисел от 1 до N.
// (В виде отдельного метода)

using System;
using static System.Console;

Clear();

WriteLine("Enter N");
WriteLine(sum(Convert.ToInt32(ReadLine())));

int sum (int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++) sum *= i;
    return sum;
}