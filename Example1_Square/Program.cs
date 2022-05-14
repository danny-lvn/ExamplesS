using System;
using static System.Console;

WriteLine("Input number");
int number = Convert.ToInt32(ReadLine());
int sqr = number * number;
WriteLine($"Number = {number} Result = {sqr}");