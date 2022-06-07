/*
**Задача 72:** Заданы 2 массива: info и data.
В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
Напишите программу, которая составит массив десятичных представлений
чисел массива data с учётом информации из массива info.

Комментарий:
первое число занимает 2 бита (01 -> 1);
второе число занимает 3 бита (111 -> 7);
третье число занимает 3 бита (000 -> 0;
четвёртое число занимает 1 бит (1 -> 1)

Входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

Выходные данные:
1, 7, 0, 1
*/

using System;
using System.Linq;
using static System.Console;

Clear();

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

if (data.Length != info.Sum()) WriteLine("Error in the data / info");
else WriteLine(String.Join(" ", GetResultArray(data, info)));

int[] GetResultArray(int[] dataArray, int[] infoArray)
{
    int[] result = new int[infoArray.Length];
    string Data = String.Join("", dataArray); // массив в строку
    for (int i = 0; i < result.Length; i++)
    {
        string subData = Data.Substring(0, infoArray[i]); // взяли подстроку из строки 
        result[i] = Convert.ToInt32(subData, 2); // конвертировали
        Data = Data.Remove(0, infoArray[i]); // отрезали то, что взяли на пред-пред-шаге
    }
    return result;
}