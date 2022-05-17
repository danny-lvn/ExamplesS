// Напишите программу, которая на вход принимает число и выдает количество цифра в этом числе.
// (Математически через метод)

using System;
using static System.Console;

Clear();

WriteLine("Enter A");
WriteLine(sod(Convert.ToInt32(ReadLine())));

int sod(int number)
{
    int n = 0;
    while (number > 0)
    {
        number = number / 10;
        n++;
    }
    return n;
}