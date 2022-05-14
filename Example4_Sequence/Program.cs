// Последовательность -N ... N

using System;
using static System.Console;

WriteLine("Enter N");
int N = Convert.ToInt32(ReadLine());
int B = -N;
while (B <= N)
{
    Write($"{B}  ");
    B++;
}
