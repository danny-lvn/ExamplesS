/*
**Задача 39:** Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

using System;
using System.Linq;
using static System.Console;

Clear();

/*
int[] ar = new int[10].Select(x => x = new Random().Next(0, 10)).ToArray();
WriteLine(String.Join(" ", ar));
WriteLine(String.Join(" ", ar.Reverse()));
*/

int length = 10;
int[] ar = new int[length].Select(x => x = new Random().Next(0, 20)).ToArray();
WriteLine(String.Join(" ", ar));

int[] ar1 = new int[length];
for (int i = 0; i < length; i++)
{
    ar1[length - 1 - i] = ar[i];
}
WriteLine(String.Join(" ", ar1));

for (int i = 0; i < length / 2; i++)
{
    int k = ar[i];
    ar[i] = ar[length - 1 - i];
    ar[length - 1 - i] = k;
}
WriteLine(String.Join(" ", ar));