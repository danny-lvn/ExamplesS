using System;
using static System.Console;

Clear();

int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
if (a1 > a2)
{
    WriteLine($"{num} -> {a1}");
}
else
{
    WriteLine($"{num} -> {a2}");
}