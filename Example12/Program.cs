// Стандартный метод вывода массива C#

using System;
using static System.Console;

Clear();

int[] r = new int[5];
string t = "123456789";
for (int i = 0; i < 5; i++)
{
    r[i] = new Random().Next(10);
}
WriteLine(String.Join(" ", r));
WriteLine(String.Join(" ", t.ToArray()));