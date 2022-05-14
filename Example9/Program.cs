/*
Напишите программу, которая принимает на вход координаты точки (X и Y),
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

using System;
using static System.Console;

Clear();

WriteLine("Enter x");
int x = Convert.ToInt32(ReadLine());
WriteLine("Enter y");
int y = Convert.ToInt32(ReadLine());

if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        WriteLine("The first quater");
    }
    else if (x < 0 && y > 0)
    {
        WriteLine("The second quater");
    }
    else if (x < 0 && y < 0)
    {
        WriteLine("The third quater");
    }
    else if (x > 0 && y < 0)
    {
        WriteLine("The fourth quater");
    }
}
else WriteLine("Enter x != 0 and y != 0");