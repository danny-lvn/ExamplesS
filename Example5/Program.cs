//Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли первое число кратным второму.
//Если первое число не кратно числу второму, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

using System;
using static System.Console;

WriteLine("Enter n1");
int n1 = Convert.ToInt32(ReadLine());
WriteLine("Enter n2");
int n2 = Convert.ToInt32(ReadLine());
if (n1 > n2)
{
    if ((n1 % n2) == 0) WriteLine("кратно");
    else WriteLine($"не кратно, остаток {n1 % n2}");
}
else WriteLine("Enter n1 > n2");