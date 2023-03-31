// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
for(int i = 1; i<=number;i++){
Write($"{i} " );
}
WriteLine();
int count = 1;
NaturalNum(number, count);

void NaturalNum(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalNum(n, count + 1);
        Write(count + " ");
    }
}
