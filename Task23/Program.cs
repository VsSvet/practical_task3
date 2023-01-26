using System;
using static System.Console;

Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine());
var list = new List<double>();
int count = 1;

while(count<number+1)
{
    list.Add(Math.Pow(count, 3));
    count += 1;
}

WriteLine(String.Join(", ", list));