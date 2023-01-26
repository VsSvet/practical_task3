using System;
using static System.Console;

Clear();

Write("Введите число: ");
int numbers = int.Parse(ReadLine());
int numbers_double = numbers;
int number = 0;
int sum = 0;

while(numbers > 0)
{
    number = numbers % 10;
    sum = (sum * 10) + number;
    number = 0;  
    numbers = numbers / 10; 
     
}

if(numbers_double == sum)
{
    Write($"{numbers_double} -> да"); 
}
else
{
    Write($"{numbers_double} -> нет");
}