// Название дня недели по его порядковому номеру

using System;
using static System.Console;

WriteLine("Input the number of the day of the week");
int n = Convert.ToInt32(ReadLine());
if (n == 1)
{
    WriteLine("Monday");
}
else if (n == 2)
{
    WriteLine("Tuesday");
}
else if (n == 3)
{
    WriteLine("Wednesday");
}
else if (n == 4)
{
    WriteLine("Thursday");
}
else if (n == 5)
{
    WriteLine("Friday");
}
else if (n == 6)
{
    WriteLine("Saturday");
}
else if (n == 7)
{
    WriteLine("Sunday");
}
else
{
    WriteLine("ISN'T A DAY OF THE WEEK");
}