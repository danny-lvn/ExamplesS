using System;
using static System.Console;

Clear();

int num = new Random().Next(10, 100);
string numS = num.ToString();
int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[1].ToString());
/*if (a1 > a2)
{
    WriteLine($"{num} -> {a1}");
}
else
{
    WriteLine($"{num} -> {a2}");
}
*/
string answer = (a1 > a2)?($"{num} -> {a1}"):($"{num} -> {a2}");
WriteLine(answer);