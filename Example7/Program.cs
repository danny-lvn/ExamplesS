/*Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.*/

using System;
using static System.Console;

WriteLine("Enter n1");
int n1 = Convert.ToInt32(ReadLine());
WriteLine("Enter n2");
int n2 = Convert.ToInt32(ReadLine());
WriteLine(n1*n1==n2?$"{n2} is a sqr {n1}":n2*n2==n1?$"{n1} is a sqr {n2}":"isn't sqrs");