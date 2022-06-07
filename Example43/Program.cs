/*
**Задача 71:** В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
ав, ва, ви, ив, св, вс
КАК Ex22 из лекций
*/

using System;
using static System.Console;

Clear();

string charsWords = "аисв";
int countCharsInWords = 2;
PrintAllWords(charsWords, countCharsInWords, "");

void PrintAllWords(string alphabet, int length, string prefix)
{
    if (length == 0) WriteLine(prefix);
    else foreach (char c in alphabet) PrintAllWords(alphabet, length - 1, prefix + c);
}