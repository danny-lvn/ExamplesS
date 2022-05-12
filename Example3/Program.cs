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
int a1 = num / 100;
int a2 = num % 10;
int result = a1*10+a2;
WriteLine(result);