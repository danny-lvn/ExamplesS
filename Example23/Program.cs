// Power of Linq library

using System;
using System.Linq;
using static System.Console;

Clear();

int[] array = new int[20].Select(x => new Random().Next(0, 1000)).ToArray();
int k = array.Where(x=>x>9&&x<100).Count();
WriteLine(String.Join(", ", array));
WriteLine(k);