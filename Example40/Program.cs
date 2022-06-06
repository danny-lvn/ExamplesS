/*
На вход подаются две строки. Написать программу, которая определит,
можно ли из верхней строки составить нижнюю.
*/

using System;
using System.Linq;
using static System.Console;

Clear();

WriteLine("Enter the first string");
string Line1 = ReadLine();
WriteLine("Enter the second string");
string Line2 = ReadLine();

string Line11 = String.Join("", Line1.ToLower().Replace(" ", "").OrderBy(c => c).ToArray());
string Line22 = String.Join("", Line2.ToLower().Replace(" ", "").OrderBy(c => c).ToArray());

WriteLine(Line11.Equals(Line22) ? "Yes" : "No");