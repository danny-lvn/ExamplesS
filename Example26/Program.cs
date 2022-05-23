/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

using System;
using System.Linq;
using static System.Console;

Clear();

/* Первый метод
WriteLine("Enter the number");
int i = Convert.ToInt32(ReadLine());
WriteLine(Convert.ToString(i, 2));
*/

/* Второй метод
WriteLine("Enter the number");
WriteLine(Meth1(Convert.ToInt32(ReadLine())));
string Meth1(int num)
{
	string res = "";
	while (num > 0)
	{
		res = num % 2 + res;
		num /= 2;
	}
	return res;
}
*/

//Третий метод - универсальный для всех систем исчисления (странно работает)
WriteLine(Meth2(20, 2));
string Meth2(int decNum, int osnSyst)
{
	string res = "";
	string nums = "0123456789ABCDEF";
	while (decNum > 0)
	{
		// Первый вариант
		//int ost = decNum / osnSyst;
		//res = nums[decNum - osnSyst * ost] + res;
		//Второй вариант
		res = nums[decNum % osnSyst] + res;
		decNum /= osnSyst;
	}
	return res;
}