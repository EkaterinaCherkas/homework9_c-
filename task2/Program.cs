// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
using System;
using static System.Console;
Clear();
WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());

void FindSumNumber (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    FindSumNumber(numberM, numberN, sum);
}

FindSumNumber(numberM, numberN, 0);