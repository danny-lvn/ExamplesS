//Напишите программу, которая выводит случайное трёхзначное число
//и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

using System;
using static System.Console;

Clear();

int num = new Random().Next(100, 1000);
WriteLine(num);
string numS = num.ToString();
string resNum = numS[0].ToString() + numS[2].ToString();
WriteLine(resNum);