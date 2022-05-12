/*Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да*/

using System;
using static System.Console;

WriteLine("Enter n");
int n = Convert.ToInt32(ReadLine());
WriteLine(n%7==0&&n%23==0?"да":"нет");