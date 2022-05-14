/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

using System;
using static System.Console;

Clear();

WriteLine("Enter xA");
int xA = Convert.ToInt32(ReadLine());
WriteLine("Enter yA");
int yA = Convert.ToInt32(ReadLine());
WriteLine("Enter xB");
int xB = Convert.ToInt32(ReadLine());
WriteLine("Enter yB");
int yB = Convert.ToInt32(ReadLine());

double res = Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2)), 2);
WriteLine($"The distance between points is {res}");